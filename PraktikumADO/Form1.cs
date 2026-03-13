using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void Koneksi()
        {
            conn = new SqlConnection("Data Source = DESKTOP-C6LEFON\\KAIJUURUN; Initial Catalog = DBAkademikADO; Integrated Security = True");
        }

        //Membuka Koneksi Database 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                MessageBox.Show("Koneksi ke Database Berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Menggunakan ExecuteScalar() - Menghitung Jumlah Mahasiswa
        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Mahasiswa";
                cmd = new SqlCommand(query, conn);
                int Jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = Jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Menghitung Jumlah Mata Kuliah dengan ExecuteScalar()
        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);
                int Jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = Jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Mengupdate  Mahasiswa SET Alamat='Yogyakarta' WHERE NIM='23110100001 dengan ExecuteNonQuery()
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "UPDATE Mahasiswa SET Alamat='Yogyakarta' WHERE NIM='23110100001'";
                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Jumlah Baris Terpengaruh : " + hasil);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Menghitung Jumlah Dosen dengan ExecuteScalar()
        private void btnHitungDs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Dosen";
                cmd = new SqlCommand(query, conn);
                int Jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = Jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Mengupdate  MataKuliah SET SKS=4 WHERE KodeMK = 'IF20101' dengan ExecuteNonQuery()
        private void btnUpdateNew_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "UPDATE MataKuliah SET SKS=4 WHERE KodeMK = 'IF20101'";
                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Jumlah Baris Terpengaruh : " + hasil);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Menginsert ProgramStudi VALUES ('MI01','Manajemen Informatika') dengan ExecuteNonQuery()
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "INSERT INTO ProgramStudi VALUES ('MI01','Manajemen Informatika') ";
                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Jumlah Baris Terpengaruh : " + hasil);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
