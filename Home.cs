using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class Home : Form
    {
        public string? currentUserId { get; private set; }

        public Home(string currentUserId)
        {
            InitializeComponent();
            this.currentUserId = currentUserId;
        }

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(currentUserId);
            profile.Show();

        }
    }
}
