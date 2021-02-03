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
    public partial class lecturerlogin : Form
    {
        public lecturerlogin()
        {
            InitializeComponent();
        }
        lecturer lecture1 = new lecturer("madam", "LC0001", "111");
        lecturer lecture2 = new lecturer("gabriel", "LC0002", "222");
        lecturer lecture3 = new lecturer("haucek", "LC0003", "333");
        lecturer lecture4 = new lecturer("sules", "LC0004", "444");
        lecturer lecture5 = new lecturer("ragu", "LC0005", "555");
        lecturer lecture6 = new lecturer("kid", "LC0006", "666");
        lecturer lecture7 = new lecturer("eustas", "LC0007", "777");
        lecturer lecture8 = new lecturer("zofia", "LC0008", "888");
        lecturer lecture9 = new lecturer("ela", "LC0009", "999");
        lecturer lecture10 = new lecturer("finka", "LC0010", "1010");

        private void returnbutton_Click(object sender, EventArgs e)
        {
            opening opening = new opening();
            this.Hide();
            opening.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text == lecture1.Idnumber && passwordtextBox.Text == lecture1.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture2.Idnumber && passwordtextBox.Text == lecture2.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }

            else if (idtextBox.Text == lecture3.Idnumber && passwordtextBox.Text == lecture3.Password)
            {
                studentaflogin afterlogin = new studentaflogin();

                afterlogin.Show();
            }

            else if (idtextBox.Text == lecture4.Idnumber && passwordtextBox.Text == lecture4.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture5.Idnumber && passwordtextBox.Text == lecture5.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture6.Idnumber && passwordtextBox.Text == lecture6.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture7.Idnumber && passwordtextBox.Text == lecture7.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture8.Idnumber && passwordtextBox.Text == lecture8.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture9.Idnumber && passwordtextBox.Text == lecture9.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == lecture10.Idnumber && passwordtextBox.Text == lecture10.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
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

        private void lecturerlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
