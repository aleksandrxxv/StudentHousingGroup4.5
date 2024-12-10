using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class DayControl : UserControl
    {
        private int dayNumber;
        public int DayNumber
        {
            get { return dayNumber; }
            set
            {
                dayNumber = value;
                lbDay.Text = dayNumber.ToString();
            }
        }

        public Image DayImage
        {
            get => pictureBox1.BackgroundImage;
            set => pictureBox1.BackgroundImage = value;
        }

        public DayControl()
        {
            InitializeComponent();
        }
    }
}
