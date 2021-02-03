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
    public partial class scheduleraflogin : Form
    {
        public scheduleraflogin()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void schedulebutton_Click(object sender, EventArgs e)
        {
            schedule schedule = new schedule();
            this.Hide();
            schedule.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            opening opening = new opening();
            this.Hide();
            opening.Show();
        }

        private void reschedulebutton_Click(object sender, EventArgs e)
        {
            move reschedule = new move();
            this.Hide();
            reschedule.Show();
        }

        private void erasebutton_Click(object sender, EventArgs e)
        {
            erasebefore before = new erasebefore();
            this.Hide();
            before.Show();
        }
    }
}
