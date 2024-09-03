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
    public partial class ItemDetailForm : Form
    {
        public ItemDetailForm()
        {
            InitializeComponent();
        }

        private void btnSaveDetailItem_Click(object sender, EventArgs e)
        {
            string idDetail = textBoxIdDetail.Text.Trim();
            string productId = textBoxProductId.Text.Trim();
            string detailNote = textBoxDetailNote.Text.Trim();
            string borrowed = "No";

            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();

                        string checkQuery = "SELECT COUNT(*) FROM detail_product WHERE id_detail_product = @idDetail";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection))
                        {
                            checkCommand.Parameters.AddWithValue("@idDetail", idDetail);
                            int count = (int)checkCommand.ExecuteScalar();

                            if (count > 0)
                            {
                                string updateQuery = "UPDATE detail_product SET product_id = @productId, product_detail_note = @productDetailNote WHERE id_detail_product = @idDetail";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection))
                                {
                                    updateCommand.Parameters.AddWithValue("@productId", productId);
                                    updateCommand.Parameters.AddWithValue("@productDetailNote", detailNote);
                                    updateCommand.Parameters.AddWithValue("@idDetail", idDetail);

                                    int rowsAffected = updateCommand.ExecuteNonQuery();
                                    MessageBox.Show(rowsAffected > 0 ? "Detail produk berhasil diperbarui!" : "Gagal memperbarui detail produk.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                string insertQuery = "INSERT INTO detail_product (id_detail_product, product_id, product_detail_note, borrowed) VALUES (@idDetail, @productId, @productDetailNote, @borrowed)";
                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection))
                                {
                                    insertCommand.Parameters.AddWithValue("@idDetail", idDetail);
                                    insertCommand.Parameters.AddWithValue("@productId", productId);
                                    insertCommand.Parameters.AddWithValue("@productDetailNote", detailNote);
                                    insertCommand.Parameters.AddWithValue("@borrowed", borrowed);

                                    int rowsAffected = insertCommand.ExecuteNonQuery();
                                    MessageBox.Show(rowsAffected > 0 ? "Detail produk baru berhasil ditambahkan!" : "Gagal menambahkan detail produk baru.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kesalahan saat menyimpan detail produk: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }

            this.Close();
        }

        private void btnCancelDetailItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
