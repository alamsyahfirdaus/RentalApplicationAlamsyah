using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Import SQL Server
using System.Data.SqlClient;

namespace RentalApplication
{
    public partial class RentalItemsForm : Form
    {
        public RentalItemsForm()
        {
            InitializeComponent();
        }

        private void RentalItemForm_Load(object sender, EventArgs e)
        {
            LoadAvailableItems();
        }

        private void LoadAvailableItems()
        {
            listBoxItem.Items.Clear();

            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();

                        string query = "SELECT id_product, product_name FROM product";
                        SqlCommand command = new SqlCommand(query, sqlConnection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string idProduct = reader["id_product"].ToString();
                                string productName = reader["product_name"].ToString();

                                string displayText = idProduct + ": " + productName;
                                listBoxItem.Items.Add(displayText);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void listBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItem.SelectedItem != null)
            {
                string selectedText = listBoxItem.SelectedItem.ToString();
                string selectedId = selectedText.Split(':')[0];

                LoadItemDescription(selectedId);
                LoadDetailItems(selectedId);
            }
        }

        private void LoadItemDescription(string id_product)
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();

                        string query = "SELECT description FROM product WHERE id_product = @id_product";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@id_product", id_product);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            textBoxDescription.Text = result.ToString(); 
                        }
                        else
                        {
                            textBoxDescription.Text = "Deskripsi tidak ditemukan.";
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close(); 
                    }
                }
            }
        }

        private void LoadDetailItems(string id_product)
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();

                        string query = "SELECT id_detail_product, borrowed FROM detail_product WHERE product_id = @id_product AND borrowed = 'No'";
                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@id_product", id_product);

                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        dataGridViewDetailItems.DataSource = dataTable;

                        dataGridViewDetailItems.Columns["id_detail_product"].HeaderText = "ID";
                        dataGridViewDetailItems.Columns["borrowed"].HeaderText = "Dipinjam";
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetailItems.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewDetailItems.SelectedRows[0].Index;
                string idDetailProduct = dataGridViewDetailItems.Rows[selectedRowIndex].Cells["id_detail_product"].Value.ToString().Trim();

                listBoxRentalItem.Items.Add(idDetailProduct);
            }
            else
            {
                MessageBox.Show("Pilih item detail terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveRental_Click(object sender, EventArgs e)
        {
            if (listBoxRentalItem.SelectedItem != null)
            {
                listBoxRentalItem.Items.Remove(listBoxRentalItem.SelectedItem);
            }
            else
            {
                MessageBox.Show("Pilih item yang akan dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveRental_Click(object sender, EventArgs e)
        {
            if (listBoxRentalItem.Items.Count > 0)
            {
                string memberId = textBoxMemberId.Text.Trim();
                DateTime rentalDate = DateTime.Now;

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        SqlTransaction transaction = null;

                        try
                        {
                            sqlConnection.Open();
                            transaction = sqlConnection.BeginTransaction();

                            foreach (var item in listBoxRentalItem.Items)
                            {
                                string detailProductId = item.ToString().Trim();
                                string idRental = GenerateIdRental(sqlConnection, transaction); // Menghasilkan id_rental unik

                                string query = "INSERT INTO rental (id_rental, member_id, detail_product_id, rental_date) " +
                                               "VALUES (@id_rental, @member_id, @detail_product_id, @rental_date)";
                                SqlCommand command = new SqlCommand(query, sqlConnection, transaction);
                                command.Parameters.AddWithValue("@id_rental", idRental);
                                command.Parameters.AddWithValue("@member_id", memberId);
                                command.Parameters.AddWithValue("@detail_product_id", detailProductId);
                                command.Parameters.AddWithValue("@rental_date", rentalDate);

                                command.ExecuteNonQuery();

                                string updateQuery = "UPDATE detail_product SET borrowed = 'Yes' WHERE id_detail_product = @id_detail_product";
                                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection, transaction);
                                updateCommand.Parameters.AddWithValue("@id_detail_product", detailProductId);

                                updateCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            listBoxRentalItem.Items.Clear();

                            MessageBox.Show("Data sewa berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (listBoxItem.SelectedItem != null)
                            {
                                listBoxItem_SelectedIndexChanged(this, EventArgs.Empty);
                            }
                        }
                        catch (SqlException sqlEx)
                        {
                            if (transaction != null)
                            {
                                transaction.Rollback();
                            }
                            MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            if (transaction != null)
                            {
                                transaction.Rollback();
                            }
                            MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tidak ada item sewa yang dipilih.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GenerateIdRental(SqlConnection sqlConnection, SqlTransaction transaction)
        {
            int idRental = 1;

            try
            {
                string query = "SELECT MAX(CAST(SUBSTRING(id_rental, 2, LEN(id_rental) - 1) AS INT)) FROM rental";
                SqlCommand command = new SqlCommand(query, sqlConnection, transaction);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    idRental = Convert.ToInt32(result) + 1;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "R" + idRental.ToString("D3");
        }

        private void btnCancelRental_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}