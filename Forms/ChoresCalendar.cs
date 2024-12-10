using StudentHousing.Classes;
using StudentHousing.ENUMS;
using StudentHousing.ManagerClasses;
using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing.Forms
{
    public partial class ChoresCalendar : Form
    {
        private User CurrentUser;
        public ChoresCalendar(User currentUser)
        {
            this.CurrentUser = currentUser;
            InitializeComponent();
            GenerateCalendar();
        }

        private void GenerateCalendar()
        {
            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            int dayCounter = 1;
            int rows = 5;
            int cols = 7;
            int spacing = 10;
            int controlWidth = 150;
            int controlHeight = 150;
            int initialOffsetY = 130;
            int initialOffsetX = 180;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (dayCounter > daysInMonth)
                        break;

                    DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayCounter);
                    List<Chore> choresForDay = ChoreManager.GetUserChoreByDay(CurrentUser.Id, date);
                    bool isCleaning = choresForDay.Any(chore => chore.typeOfChore == ChoreType.Cleaning); ;

                    Image img = null;
                    if (isCleaning)
                    {
                        img = Properties.Resources.cleaning;
                    }

                    DayControl dayControl = new DayControl
                    {
                        DayNumber = dayCounter,
                        DayImage = img,
                        Location = new Point(col * (controlWidth + spacing) + initialOffsetX, row * (controlHeight + spacing) + initialOffsetY),
                        Size = new Size(controlWidth, controlHeight)
                    };

                    this.Controls.Add(dayControl);
                    dayCounter++;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frm = new Home(this.CurrentUser);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
