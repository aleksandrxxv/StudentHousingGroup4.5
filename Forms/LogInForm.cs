﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.Forms;
using StudentHousing.ManagerClasses;
using static System.Windows.Forms.DataFormats;

namespace StudentHousing
{
    public partial class LogInForm : Form
    {
        private List<User> users;// = new List<User>();
        private bool authenticated;

        public bool Authenticated
        {
            get { return authenticated; }
            set { authenticated = value; }
        }

        public LogInForm()
        {
            this.authenticated = false;
            this.users = new List<User>();
            InitializeComponent();
            this.AcceptButton = loginButton;
            this.KeyDown += LoginForm_KeyDown;
            this.KeyPreview = true;

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loginButton.PerformClick();
            }
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
            }
            else
            {
                authenticated = false;
            }

            if (authenticated)
            {
                if (user.IsAdmin)
                {
                    AdminHomeForm frm = new AdminHomeForm();
                    frm.Show();
                    this.Hide();
                    frm.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    Home frm = new Home(user);
                    frm.Show();
                    this.Hide();
                    frm.FormClosed += (s, args) => this.Close();
                }
                

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
