using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Sign_In sign_In = new Sign_In();
            sign_In.Show();
            this.Hide();
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
    }
}
