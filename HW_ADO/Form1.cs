using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; 
            Initial Catalog = Warehouse; 
            Integrated Security = True; ";
            connection = new SqlConnection("");
            connection.ConnectionString = connectionString;
            connection.Open();
            MessageBox.Show("123");
            //connection.ConnectionString = connectionString;
            connection.Close();
            MessageBox.Show("321");
            /*Connect Timeout = 30; 
            Encrypt = False;
            TrustServerCertificate = False;
            ApplicationIntent = ReadWrite;
            MultiSubnetFailover = False*/
        }
    }
}
