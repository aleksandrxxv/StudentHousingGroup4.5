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
    public partial class ProfileForm : Form
    {
        //private? User user = new User();
        private string userId = string.Empty;
        public ProfileForm(string currentUserId)
        {
            userId = currentUserId;
            InitializeComponent();
            lbId.Text = $"UserId: {currentUserId}";

        }
    }
}
