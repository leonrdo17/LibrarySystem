using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class addschedule : Form
    {
        OleDbConnection cnnoledb = new OleDbConnection();
        OleDbCommand cmdadd = new OleDbCommand();

        public addschedule()
        {
            InitializeComponent();
            cnnoledb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ioopdatabase.accdb";
            cnnoledb.Open();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            scheduleraflogin afterlogin = new scheduleraflogin();
            this.Hide();
            afterlogin.Show();
        }

        private void addschedule_Load(object sender, EventArgs e)
        {
            classroomcomboBox.Items.Add("B Auditorium 1");
            classroomcomboBox.Items.Add("B Auditorium 2");
            classroomcomboBox.Items.Add("B Computer Lab 1");
            classroomcomboBox.Items.Add("B Computer Lab 2");
            classroomcomboBox.Items.Add("B Engineer Lab 1");
            classroomcomboBox.Items.Add("B Engineer Lab 2");
            classroomcomboBox.Items.Add("B Regular Class 1");
            classroomcomboBox.Items.Add("B Regular Class 2");
            classroomcomboBox.Items.Add("B Regular Class 3");
            classroomcomboBox.Items.Add("B Regular Class 4");
            classroomcomboBox.Items.Add("D Auditorium 1");
            classroomcomboBox.Items.Add("D Auditorium 2");
            classroomcomboBox.Items.Add("D Computer Lab 1");
            classroomcomboBox.Items.Add("D Computer Lab 2");
            classroomcomboBox.Items.Add("D Engineer Lab 1");
            classroomcomboBox.Items.Add("D Engineer Lab 2");
            classroomcomboBox.Items.Add("D Regular Class 1");
            classroomcomboBox.Items.Add("D Regular Class 2");
            classroomcomboBox.Items.Add("D Regular Class 3");
            classroomcomboBox.Items.Add("D Regular Class 4");
            classroomcomboBox.Items.Add("E Auditorium 1");
            classroomcomboBox.Items.Add("E Auditorium 2");
            classroomcomboBox.Items.Add("E Computer Lab 1");
            classroomcomboBox.Items.Add("E Computer Lab 2");
            classroomcomboBox.Items.Add("E Engineer Lab 1");
            classroomcomboBox.Items.Add("E Engineer Lab 2");
            classroomcomboBox.Items.Add("E Regular Class 1");
            classroomcomboBox.Items.Add("E Regular Class 2");
            classroomcomboBox.Items.Add("E Regular Class 3");
            classroomcomboBox.Items.Add("E Regular Class 4");
            datecomboBox.Items.Add("18/06/18");
            datecomboBox.Items.Add("19/06/18");
            datecomboBox.Items.Add("20/06/18");
            datecomboBox.Items.Add("21/06/18");
            datecomboBox.Items.Add("22/06/18");
            datecomboBox.Items.Add("23/06/18");
            datecomboBox.Items.Add("25/06/18");
            datecomboBox.Items.Add("26/06/18");
            datecomboBox.Items.Add("27/06/18");
            datecomboBox.Items.Add("28/06/18");
            datecomboBox.Items.Add("29/06/18");
            datecomboBox.Items.Add("30/06/18");
            datecomboBox.Items.Add("02/07/18");
            datecomboBox.Items.Add("03/07/18");
            datecomboBox.Items.Add("04/07/18");
            datecomboBox.Items.Add("05/07/18");
            timecomboBox.Items.Add("8:30 - 9:30");
            timecomboBox.Items.Add("9:30 - 10:30");
            timecomboBox.Items.Add("10:30 - 11:30");
            timecomboBox.Items.Add("11:30 - 12:30");
            timecomboBox.Items.Add("13:00 - 14:00");
            timecomboBox.Items.Add("14:00 - 15:00");
            timecomboBox.Items.Add("15:00 - 16:00");
            timecomboBox.Items.Add("16:00 - 17:00");
            timecomboBox.Items.Add("17:00 - 18:00");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string classroom = (classroomcomboBox.Text).Replace(' ', '_');
            cmdadd.CommandText = "UPDATE [" + classroom + "] SET [" + timecomboBox.Text + "] = '" + idtextBox.Text + "' Where Day = '" + datecomboBox.Text + "';";
            cmdadd.CommandType = CommandType.Text;
            cmdadd.Connection = cnnoledb;
            cmdadd.ExecuteNonQuery();
            MessageBox.Show("Adding Complete");
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
