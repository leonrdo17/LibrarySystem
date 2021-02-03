using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class replacement : Form
    {
        public replacement()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            scheduleraflogin afterlogin = new scheduleraflogin();
            this.Hide();
            afterlogin.Show();
        }

        private void replacement_Load(object sender, EventArgs e)
        {
            blocktypecomboBox.Items.Add("Block B");
            blocktypecomboBox.Items.Add("Block D");
            blocktypecomboBox.Items.Add("Block E");
            typeofclasscomboBox.Items.Add("Auditorium");
            typeofclasscomboBox.Items.Add("Computer Lab");
            typeofclasscomboBox.Items.Add("Engineering Lab");
            typeofclasscomboBox.Items.Add("Regular Class");
            daycomboBox.Items.Add("Monday");
            daycomboBox.Items.Add("Tuesday");
            daycomboBox.Items.Add("Wednesday");
            daycomboBox.Items.Add("Thursday");
            daycomboBox.Items.Add("Friday");
            daycomboBox.Items.Add("Saturday");
            daycomboBox.Items.Add("Sunday");
            timecomboBox.Items.Add("8:30");
            timecomboBox.Items.Add("9:30");
            timecomboBox.Items.Add("10:30");
            timecomboBox.Items.Add("11:30");
            timecomboBox.Items.Add("13:00");
            timecomboBox.Items.Add("14:00");
            timecomboBox.Items.Add("15:00");
            timecomboBox.Items.Add("16:00");
            timecomboBox.Items.Add("17:00");
            timecomboBox.Items.Add("18:00");
            hourscomboBox.Items.Add("1 Hour");
            hourscomboBox.Items.Add("2 Hours");
            hourscomboBox.Items.Add("3 Hours");
        }
    }
}
