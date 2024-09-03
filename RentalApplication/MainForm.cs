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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // Inisialisasi komponen UI
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Memuat data anggota dari database saat form dimuat
            LoadMembersData();
        }

        private void LoadMembersData()
        {
            // Memuat data anggota dari database
            using (Connection connection = new Connection()) // Blok using untuk memastikan koneksi dibersihkan secara otomatis
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        // Membuka koneksi ke database
                        sqlConnection.Open();

                        // Query untuk mengambil data anggota
                        string query = "SELECT id_member, member_name, address, phone_number FROM member";

                        // Membuat objek SqlCommand untuk menjalankan query
                        SqlCommand command = new SqlCommand(query, sqlConnection);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Membuat DataTable untuk menampung hasil query
                            DataTable dataTable = new DataTable();

                            // Memuat data dari SqlDataReader ke DataTable
                            dataTable.Load(reader);

                            // Menetapkan DataTable sebagai sumber data untuk DataGridView
                            dataGridViewMember.DataSource = dataTable;

                            // Mengatur teks header dan lebar kolom di DataGridView
                            dataGridViewMember.Columns["id_member"].HeaderText = "ID";
                            dataGridViewMember.Columns["member_name"].HeaderText = "Nama_Anggota";
                            dataGridViewMember.Columns["address"].HeaderText = "Alamat";
                            dataGridViewMember.Columns["phone_number"].HeaderText = "Nomor_Telepon";
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        // Menampilkan pesan kesalahan SQL
                        MessageBox.Show("Kesalahan SQL: " + sqlEx.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Menampilkan pesan kesalahan umum
                        MessageBox.Show("Kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Menutup koneksi setelah operasi selesai
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            // Membuka form untuk menambah anggota baru
            MemberForm memberDataForm = new MemberForm
            {
                // Mengatur judul form
                Text = "Add Member",

                // Mengatur teks label di form
                labelMemberForm = { Text = "ADD MEMBER" }
            };

            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        // Membuka koneksi ke database
                        sqlConnection.Open();

                        // Query untuk mendapatkan nilai ID tertinggi dari tabel 'member'
                        string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(id_member, 2, LEN(id_member) - 1) AS INT)), 0) + 1 FROM member";

                        // Membuat objek SqlCommand untuk menjalankan query
                        SqlCommand command = new SqlCommand(query, sqlConnection);

                        // Mendapatkan nomor ID anggota baru
                        int newMemberIdNumber = (int)command.ExecuteScalar();

                        // Format nomor ID anggota baru menjadi 'Mxxx'
                        string newMemberId = "M" + newMemberIdNumber.ToString("D3");

                        // Mengisi textBox dengan ID anggota baru
                        memberDataForm.textBoxIdMember.Text = newMemberId;
                    }
                    catch (Exception ex)
                    {
                        // Menampilkan pesan kesalahan jika terjadi kesalahan saat mengambil ID anggota baru
                        MessageBox.Show("Kesalahan saat mengambil ID anggota baru: " + ex.Message);
                    }
                    finally
                    {
                        // Menutup koneksi setelah operasi selesai
                        sqlConnection.Close();
                    }
                }
            }

            // Menampilkan form tambah anggota dan menunggu pengguna untuk menutupnya
            memberDataForm.ShowDialog();

            // Memuat ulang data anggota setelah form ditutup
            LoadMembersData();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            // Memulai proses edit anggota
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                // Mendapatkan indeks baris yang dipilih
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;

                // Mengambil id_member sebagai string
                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();

                // Membuka form untuk mengedit data anggota
                MemberForm memberDataForm = new MemberForm
                {
                    // Mengatur judul form
                    Text = "Edit Member",

                    // Mengatur teks label di form
                    labelMemberForm = { Text = "EDIT MEMBER" }
                };

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        try
                        {
                            // Membuka koneksi ke database
                            sqlConnection.Open();

                            // Query untuk mengambil data anggota berdasarkan id_member
                            string query = "SELECT member_name, address, phone_number FROM member WHERE id_member = @memberId";

                            // Membuat objek SqlCommand untuk menjalankan query
                            SqlCommand command = new SqlCommand(query, sqlConnection);

                            // Menambahkan parameter ID anggota ke query
                            command.Parameters.AddWithValue("@memberId", memberId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Mengisi form dengan data anggota yang diambil
                                    memberDataForm.textBoxIdMember.Text = memberId.Trim();
                                    memberDataForm.textBoxMemberName.Text = reader["member_name"].ToString();
                                    memberDataForm.textBoxAddress.Text = reader["address"].ToString();
                                    memberDataForm.textBoxPhoneNumber.Text = reader["phone_number"].ToString();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Menampilkan pesan kesalahan jika terjadi masalah
                            MessageBox.Show("Kesalahan saat mengambil data anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            // Menutup koneksi setelah operasi selesai
                            sqlConnection.Close();
                        }
                    }
                }

                // Menampilkan form edit anggota dan menunggu pengguna untuk menutupnya
                memberDataForm.ShowDialog();

                // Memuat ulang data anggota setelah form ditutup
                LoadMembersData();
            }
            else
            {
                // Menampilkan peringatan jika tidak ada anggota yang dipilih untuk diedit
                MessageBox.Show("Silakan pilih anggota yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            // Memulai proses penghapusan anggota
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                // Mendapatkan indeks baris yang dipilih
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;

                // Mengambil id_member dari baris yang dipilih
                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();

                // Menampilkan dialog konfirmasi untuk menghapus anggota
                DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus anggota ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Jika pengguna memilih 'Yes'
                if (dialogResult == DialogResult.Yes)
                {
                    using (Connection connection = new Connection())
                    {
                        using (SqlConnection sqlConnection = connection.GetConnection())
                        {
                            try
                            {
                                // Membuka koneksi ke database
                                sqlConnection.Open();

                                // Query untuk menghapus anggota berdasarkan id_member
                                string query = "DELETE FROM member WHERE id_member = @memberId";

                                // Membuat objek SqlCommand untuk menjalankan query
                                SqlCommand command = new SqlCommand(query, sqlConnection);

                                // Menambahkan parameter ID anggota ke query
                                command.Parameters.AddWithValue("@memberId", memberId);

                                // Menjalankan query penghapusan
                                int rowsAffected = command.ExecuteNonQuery();

                                // Menampilkan pesan sukses jika penghapusan berhasil
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Anggota berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    // Menampilkan pesan kesalahan jika tidak ada baris yang dihapus
                                    MessageBox.Show("Gagal menghapus anggota.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Menampilkan pesan kesalahan jika terjadi masalah
                                MessageBox.Show("Kesalahan saat menghapus anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                // Menutup koneksi setelah operasi selesai
                                sqlConnection.Close();
                            }
                        }
                    }

                    // Memuat ulang data anggota setelah penghapusan
                    LoadMembersData();
                }
            }
            else
            {
                // Menampilkan peringatan jika tidak ada anggota yang dipilih untuk dihapus
                MessageBox.Show("Silakan pilih anggota yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMember.Rows[e.RowIndex];
                var cellValue = row.Cells["id_member"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    string memberId = cellValue.ToString().Trim();

                    LoadRentalItems(memberId);
                }
                else
                {
                    MessageBox.Show("ID anggota tidak valid atau tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadRentalItems(string memberId)
        {
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        sqlConnection.Open();

                        string query = @"
                SELECT 
                    r.id_rental,
                    p.product_name,
                    dp.id_detail_product,
                    r.rental_date, 
                    r.rental_return_date
                FROM rental r
                INNER JOIN detail_product dp ON r.detail_product_id = dp.id_detail_product
                INNER JOIN product p ON dp.product_id = p.id_product
                WHERE r.member_id = @memberId ORDER BY r.id_rental DESC";

                        SqlCommand command = new SqlCommand(query, sqlConnection);
                        command.Parameters.AddWithValue("@memberId", memberId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridViewRental.DataSource = dataTable;

                            dataGridViewRental.Columns["id_rental"].HeaderText = "ID";
                            dataGridViewRental.Columns["product_name"].HeaderText = "Nama_Produk";
                            dataGridViewRental.Columns["id_detail_product"].HeaderText = "ID_Detail_Produk";
                            dataGridViewRental.Columns["rental_date"].HeaderText = "Tgl_Rental";
                            dataGridViewRental.Columns["rental_return_date"].HeaderText = "Tgl_Kembali";
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

        private void btnMenageItems_Click(object sender, EventArgs e)
        {
            MenageItemsForm menageItemsForm = new MenageItemsForm();
            menageItemsForm.Show();
        }

        private void btnRentalNewItems_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewMember.SelectedRows[0].Index;
                string memberId = dataGridViewMember.Rows[selectedRowIndex].Cells["id_member"].Value.ToString().Trim();
                string memberName = dataGridViewMember.Rows[selectedRowIndex].Cells["member_name"].Value.ToString().Trim();

                RentalItemsForm rentalItemsForm = new RentalItemsForm();

                rentalItemsForm.textBoxMemberId.Text = memberId;
                rentalItemsForm.textBoxMemberName.Text = memberName;

                rentalItemsForm.Show();
            }
            else
            {
                MessageBox.Show("Pilih anggota terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturnRentalItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewRental.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewRental.SelectedRows[0].Index;
                string rentalId = dataGridViewRental.Rows[selectedRowIndex].Cells["id_rental"].Value.ToString().Trim();
                string detailProductId = dataGridViewRental.Rows[selectedRowIndex].Cells["id_detail_product"].Value.ToString().Trim();

                using (Connection connection = new Connection())
                {
                    using (SqlConnection sqlConnection = connection.GetConnection())
                    {
                        try
                        {
                            sqlConnection.Open();
                            DateTime currentDate = DateTime.Now;

                            string updateRentalQuery = "UPDATE rental SET rental_return_date = @currentDate WHERE id_rental = @rentalId";
                            string updateDetailProductQuery = "UPDATE detail_product SET borrowed = 'No' WHERE id_detail_product = @detailProductId";

                            SqlCommand updateRentalCommand = new SqlCommand(updateRentalQuery, sqlConnection);
                            updateRentalCommand.Parameters.AddWithValue("@currentDate", currentDate);
                            updateRentalCommand.Parameters.AddWithValue("@rentalId", rentalId);

                            SqlCommand updateDetailProductCommand = new SqlCommand(updateDetailProductQuery, sqlConnection);
                            updateDetailProductCommand.Parameters.AddWithValue("@detailProductId", detailProductId);

                            updateRentalCommand.ExecuteNonQuery();
                            updateDetailProductCommand.ExecuteNonQuery();

                            MessageBox.Show("Item berhasil dikembalikan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                if (dataGridViewMember.SelectedRows.Count > 0)
                {
                    string memberId = dataGridViewMember.SelectedRows[0].Cells["id_member"].Value.ToString().Trim();
                    LoadRentalItems(memberId);
                }
            }
            else
            {
                MessageBox.Show("Pilih item rental yang ingin dikembalikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
