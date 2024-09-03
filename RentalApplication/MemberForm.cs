using System;
using System.Windows.Forms;
// Import SQL Server
using System.Data.SqlClient;

namespace RentalApplication
{
    public partial class MemberForm : Form // Kelas MemberForm yang merupakan turunan dari Form
    {
        public MemberForm()
        {
            InitializeComponent(); // Menginisialisasi komponen UI pada form
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari kontrol input dan menghapus spasi di awal dan akhir
            string idMember = textBoxIdMember.Text.Trim();
            string memberName = textBoxMemberName.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();

            // Validasi input untuk memastikan semua field diisi
            if (string.IsNullOrWhiteSpace(memberName) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                // Menampilkan pesan peringatan jika ada field yang kosong
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan eksekusi jika validasi gagal
            }

            // Menggunakan koneksi ke database
            using (Connection connection = new Connection())
            {
                using (SqlConnection sqlConnection = connection.GetConnection())
                {
                    try
                    {
                        // Membuka koneksi ke database
                        sqlConnection.Open();

                        // Query untuk memeriksa apakah ID anggota sudah ada
                        string checkQuery = "SELECT COUNT(*) FROM member WHERE id_member = @idMember";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, sqlConnection);
                        checkCommand.Parameters.AddWithValue("@idMember", idMember);

                        // Mengecek keberadaan ID anggota
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0) // Jika anggota sudah ada
                        {
                            // Query untuk memperbarui data anggota
                            string updateQuery = "UPDATE member SET member_name = @memberName, address = @address, phone_number = @phoneNumber WHERE id_member = @idMember";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.Parameters.AddWithValue("@memberName", memberName);
                            updateCommand.Parameters.AddWithValue("@address", address);
                            updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                            updateCommand.Parameters.AddWithValue("@idMember", idMember);

                            // Memperbarui data anggota
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Menampilkan hasil operasi
                            MessageBox.Show(rowsAffected > 0 ? "Data anggota berhasil diperbarui!" : "Gagal memperbarui data anggota.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // Jika anggota belum ada
                        {
                            // Query untuk menambahkan anggota baru
                            string insertQuery = "INSERT INTO member (id_member, member_name, address, phone_number) VALUES (@idMember, @memberName, @address, @phoneNumber)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.Parameters.AddWithValue("@idMember", idMember);
                            insertCommand.Parameters.AddWithValue("@memberName", memberName);
                            insertCommand.Parameters.AddWithValue("@address", address);
                            insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                            // Menyimpan data anggota baru
                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            // Menampilkan hasil operasi
                            MessageBox.Show(rowsAffected > 0 ? "Anggota baru berhasil ditambahkan!" : "Gagal menambahkan anggota baru.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex) // Menangani kesalahan yang mungkin terjadi
                    {
                        // Menampilkan pesan kesalahan jika terjadi masalah saat menyimpan data
                        MessageBox.Show("Kesalahan saat menyimpan data anggota: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Menutup koneksi setelah operasi selesai
                        sqlConnection.Close();
                    }
                }
            }

            // Menutup form setelah proses selesai
            this.Close();
        }

        private void btnCancelMember_Click(object sender, EventArgs e)
        {
            // Menutup form tanpa menyimpan perubahan
            this.Close();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
