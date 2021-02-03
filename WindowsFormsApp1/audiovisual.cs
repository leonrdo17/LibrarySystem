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
    public partial class audiovisual : Form
    {
        public audiovisual()
        {
            InitializeComponent();
        }

        private void audiovisual_Load(object sender, EventArgs e)
        {
            if (noradiobutton.Checked)
            {
                additionalsgroupbox.Enabled = false;
            }

            else if (yesradiobutton.Checked)
            {
                additionalsgroupbox.Enabled = true;
            }
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Request Confirmed" + "\n" + "Thankyou for your booking" + "\n" + "Your Booking will be proceed!");
            opening opening = new opening();
            this.Hide();
            opening.Show();
            
            
        }

        private void noradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            additionalsgroupbox.Enabled = false;
        }

        private void yesradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            additionalsgroupbox.Enabled = true;
        }
    }
}
