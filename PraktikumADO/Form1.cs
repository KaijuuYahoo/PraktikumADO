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
            conn = new SqlConnection(
                "Data Source = DESKTOP - C6LEFON\\KAIJUURUN; Initial Catalog = YourDatabaseName; Integrated Security = True"
                );
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
