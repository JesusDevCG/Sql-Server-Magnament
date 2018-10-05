using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    public partial class Form1 : Form
    {
        bool cl = true;
        SqlServer connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlServer();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                connection.SQLConnect = new SqlConnectionStringBuilder();
                connection.SQLConnect.DataSource = servertxt.Text;
                connection.SQLConnect.UserID = usertxt.Text;
                connection.SQLConnect.Password = passtxt.Text;
                connection.SQLConnect.InitialCatalog = catalogtxt.Text;

                using (connection.connection = new SqlConnection(connection.SQLConnect.ConnectionString))
                {
                    connection.connection.Open();
                    magnamentForm fr = new magnamentForm(connection);
                    fr.Show();
                    cl = false;
                    this.Close();
                    
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(cl)
                Application.Exit();
        }
    }
}
