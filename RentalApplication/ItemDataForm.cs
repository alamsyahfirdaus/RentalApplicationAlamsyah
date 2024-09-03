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
    public partial class ItemDataForm : Form
    {
        public ItemDataForm()
        {
            InitializeComponent();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            string idProduct = textBoxIdProduct.Text.Trim();
            string productName = textBoxProductName.Text.Trim();
            string description = textBoxDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open(); 

                        string checkQuery = "SELECT COUNT(*) FROM product WHERE id_product = @idProduct";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                        checkCommand.Parameters.AddWithValue("@idProduct", idProduct);

                        int count = (int)checkCommand.ExecuteScalar(); 

                        if (count > 0) 
                        {
                            string updateQuery = "UPDATE product SET product_name = @productName, description = @description WHERE id_product = @idProduct";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.Parameters.AddWithValue("@productName", productName);
                            updateCommand.Parameters.AddWithValue("@description", description);
                            updateCommand.Parameters.AddWithValue("@idProduct", idProduct);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Data produk berhasil diperbarui!" : "Gagal memperbarui data produk.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO product (id_product, product_name, description) VALUES (@idProduct, @productName, @description)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.Parameters.AddWithValue("@idProduct", idProduct);
                            insertCommand.Parameters.AddWithValue("@productName", productName);
                            insertCommand.Parameters.AddWithValue("@description", description);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            MessageBox.Show(rowsAffected > 0 ? "Produk baru berhasil ditambahkan!" : "Gagal menambahkan produk baru.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan saat menyimpan data produk: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }

            this.Close();
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
