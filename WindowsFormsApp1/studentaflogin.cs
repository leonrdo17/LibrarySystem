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
    public partial class studentaflogin : Form
    {
        public studentaflogin()
        {
            InitializeComponent();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            opening opening = new opening();
            this.Hide();
            opening.Show();
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            snlchecked check = new snlchecked();
            this.Hide();
            check.Show();
        }

        private void bookingbutton_Click(object sender, EventArgs e)
        {
            snlbooking book = new snlbooking();
            this.Hide();
            book.Show();
        }
    }
}
