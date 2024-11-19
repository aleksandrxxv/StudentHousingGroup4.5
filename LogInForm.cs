using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StudentHousing
{
    public partial class LogInForm : Form
    {
        List<User> users = new List<User>();
        private bool authenticated = false;

        public bool Authenticated
        {
            get { return authenticated; }
            set { authenticated = value; }
        }

        public LogInForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (username == "" || password == "")
            {
                lbError.Text = "Enter both the username and the password!";
                return;
            }
            User user = UserManager.LogIn(username, password);
            if (user != null)
            {
                authenticated = true;
            }else
            {
                authenticated = false;
            }

            if (authenticated)
            {
                Home frm = new Home(user);
                frm.Show();
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();

            }

        }

    }
}
