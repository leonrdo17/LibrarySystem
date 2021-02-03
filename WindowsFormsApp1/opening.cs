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
    public partial class opening : Form
    {
        public opening()
        {
            InitializeComponent();
        }

        private void schedulerbutton_Click(object sender, EventArgs e)
        {
            schedulerlogin schelog = new schedulerlogin();
            this.Hide();
            schelog.Show();
        }

        private void lecturerbutton_Click(object sender, EventArgs e)
        {
            lecturerlogin leclog = new lecturerlogin();
            this.Hide();
            leclog.Show();
        }

        private void studentbutton_Click(object sender, EventArgs e)
        {
            studentlogin stulog = new studentlogin();
            this.Hide();
            stulog.Show();
        }
    }
}
