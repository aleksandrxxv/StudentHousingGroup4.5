using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class AnnouncementsForm : Form
    {
        public User CurrentUser { get; private set; }
        public AnnouncementsForm(User currentUser)
        {
            InitializeComponent();
            this.CurrentUser = currentUser;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frm = new Home(this.CurrentUser);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
