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
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }

        student student1 = new student("Peter", "TP0001", "111");
        student student2 = new student("Samuel", "TP0002", "222");
        student student3 = new student("Tony", "TP0003", "333");
        student student4 = new student("Steven", "TP0004", "444");
        student student5 = new student("Jesi", "TP0005", "555");
        student student6 = new student("Mei", "TP0006", "666");
        student student7 = new student("TChala", "TP0007", "777");
        student student8 = new student("Irene", "TP0008", "888");
        student student9 = new student("Kaneki", "TP0009", "999");
        student student10 = new student("Goku", "TP0010", "1010");
        student student11 = new student("Bulma", "TP0011", "1111");
        student student12 = new student("Seulgi", "TP0012", "1212");
        student student13 = new student("Mario", "TP0013", "1313");
        student student14 = new student("Luigi", "TP0014", "1414");
        student student15 = new student("Millenia", "TP0015", "1515");

        private void button_Click(object sender, EventArgs e)
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
            if (idtextBox.Text == student1.Idnumber && passwordtextBox.Text == student1.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student2.Idnumber && passwordtextBox.Text == student2.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }

            else if (idtextBox.Text == student3.Idnumber && passwordtextBox.Text == student3.Password)
            {
                studentaflogin afterlogin = new studentaflogin();

                afterlogin.Show();
            }

            else if (idtextBox.Text == student4.Idnumber && passwordtextBox.Text == student4.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student5.Idnumber && passwordtextBox.Text == student5.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student6.Idnumber && passwordtextBox.Text == student6.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student7.Idnumber && passwordtextBox.Text == student7.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student8.Idnumber && passwordtextBox.Text == student8.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student9.Idnumber && passwordtextBox.Text == student9.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student10.Idnumber && passwordtextBox.Text == student10.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student11.Idnumber && passwordtextBox.Text == student11.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student12.Idnumber && passwordtextBox.Text == student12.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student13.Idnumber && passwordtextBox.Text == student13.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student14.Idnumber && passwordtextBox.Text == student14.Password)
            {
                studentaflogin afterlogin = new studentaflogin();
                this.Hide();
                afterlogin.Show();
            }
            else if (idtextBox.Text == student15.Idnumber && passwordtextBox.Text == student15.Password)
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

        private void studentlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
            


   
      
            
