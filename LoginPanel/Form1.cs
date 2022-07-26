using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxtb_MouseEnter(object sender, EventArgs e)
        {
            if(usernameTxtb.Text == "USERNAME")
            {
                usernameTxtb.Text =string.Empty;
                usernameTxtb.ForeColor = Color.Black;
                usernameTxtb.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            }
        }

        private void usernameTxtb_MouseLeave(object sender, EventArgs e)
        {
            if (usernameTxtb.Text == string.Empty)
            {
                usernameTxtb.Text = "USERNAME";
                usernameTxtb.ForeColor = Color.DarkGray;
                usernameTxtb.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Italic);
            }
        }

        private void passwordTxtb_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTxtb.Text == "PASSWORD")
            {
                passwordTxtb.Text = string.Empty;
                passwordTxtb.ForeColor = Color.Black;
                passwordTxtb.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            }
        }

        private void passwordTxtb_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTxtb.Text == string.Empty)
            {
                passwordTxtb.Text = "PASSWORD";
                passwordTxtb.ForeColor = Color.DarkGray;
                passwordTxtb.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Italic);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTxtb.Text == "USERNAME")
            {
                usernamerequiredLbl.ForeColor = Color.Red;
                usernamerequiredLbl.Text = "Username required";
            }
            else
            {
                usernamerequiredLbl.Text = string.Empty;
            }
            if (passwordTxtb.Text == "PASSWORD")
            {
                passwordrequiredLbl.ForeColor = Color.Red;
                passwordrequiredLbl.Text = "Password required";
            }
            else
            {
                passwordrequiredLbl.Text = string.Empty;
            }
        }
    }
}
