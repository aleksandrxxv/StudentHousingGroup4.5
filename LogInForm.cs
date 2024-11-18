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

namespace StudentHousing
{
    public partial class LogInForm : Form
    {
        List<User> users = new List<User>();
        public LogInForm()
        {
            InitializeComponent();
        }
        private bool LogIn(string username, string password)
        {
            string filePath = "C:\\Users\\krisy\\Desktop\\StudentHousingGroup4.5\\Database\\users.json";
            string hashedPassword = User.HashPassword(password);

            try
            {
                string json = File.ReadAllText(filePath);
                var jsonUsers = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

                if (jsonUsers != null)
                {
                    foreach (var userJson in jsonUsers)
                    {
                        string storedUsername = userJson["UserName"].ToString();
                        string storedPasswordHash = userJson["PasswordHash"].ToString();
                        if (storedUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && storedPasswordHash.Equals(hashedPassword))
                        {
                            MessageBox.Show("Successful log in");
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
            lbError.Text = "Wrong credentials please try again";
            return false;
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
            string passwordHash = password;
            bool isLogged = LogIn(username, password);
            
        }

    }
}
