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
    public partial class schedulerlogin : Form
    {
        public schedulerlogin()
        {
            InitializeComponent();
        }

        scheduler scheduler1 = new scheduler("Yoona", "SCH1", "111");
        scheduler scheduler2 = new scheduler("Vegeta", "SCH2", "222");
        scheduler scheduler3 = new scheduler("Van Gogh", "SCH3", "333");

        private void returnbutton_Click(object sender, EventArgs e)
        {
            opening opening = new opening();
            this.Hide();
            opening.Show();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextBox.Clear();
            passwordtextBox.Clear();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(idtextBox.Text == scheduler1.Idnumber && passwordtextBox.Text == scheduler1.Password)
            {
                scheduleraflogin afterlogin = new scheduleraflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == scheduler2.Idnumber && passwordtextBox.Text == scheduler2.Password)
            {
                scheduleraflogin afterlogin = new scheduleraflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == scheduler3.Idnumber && passwordtextBox.Text == scheduler3.Password)
            {
                scheduleraflogin afterlogin = new scheduleraflogin();
                this.Hide();
                afterlogin.Show();
            }
            else
            {
                MessageBox.Show("Login Invalid");
                idtextBox.Clear();
                passwordtextBox.Clear();
            }
        }

        private void schedulerlogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
