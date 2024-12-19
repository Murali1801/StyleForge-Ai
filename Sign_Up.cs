using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sign_up_and_Sign_in_Systems
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string emailid = txtemail.Text;

            String connectionstring = "server=K-DESKTOP\\SQLEXPRESS;database=TestDB;TrustServerCertificate=True;integrated security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                //string querystatement = "SELECT * FROM Login";
                string inputquery = "INSERT INTO Login( email,username, passwd) VALUES (@email,@username,@password)";

                using(SqlCommand cmd = new SqlCommand(inputquery, conn))
                {
                    cmd.Parameters.AddWithValue("@email", emailid);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
        

                    conn.Open();
                    int rows_affected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            Sign_In sign_In = new Sign_In();
            sign_In.Show();
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

            Console.WriteLine("Input Read");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_In sign_In = new Sign_In();
            sign_In.Show();
            
            this.Hide();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSignUp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
