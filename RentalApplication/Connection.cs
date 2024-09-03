using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Mengimpor namespace untuk bekerja dengan SQL Server

namespace RentalApplication
{
    public class Connection : IDisposable // Kelas Connection yang mengimplementasikan IDisposable
    {
        private const string ConnectionString = @"Data Source=laptop-ntq02q33\sqlserver; Initial Catalog=db_rental; Integrated Security=true";
        // String koneksi yang berisi informasi untuk terhubung ke database SQL Server

        private SqlConnection sqlConnection; // Variabel untuk menyimpan objek koneksi SQL

        public Connection()
        {
            sqlConnection = new SqlConnection(ConnectionString); // Inisialisasi objek SqlConnection dengan string koneksi
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection; // Mengembalikan objek SqlConnection yang telah diinisialisasi
        }

        public void Dispose()
        {
            if (sqlConnection != null) // Memeriksa apakah objek SqlConnection tidak null
            {
                sqlConnection.Dispose(); // Menghancurkan objek SqlConnection dan membebaskan sumber daya yang digunakan
                sqlConnection = null; // Menetapkan objek SqlConnection ke null setelah dihancurkan
            }
        }
    }
}
