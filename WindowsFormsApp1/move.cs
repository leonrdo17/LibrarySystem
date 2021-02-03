﻿using System;
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
    public partial class move : Form
    {
        OleDbConnection cnnoledb = new OleDbConnection();

        public move()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            movedelete delete = new movedelete();
            this.Hide();
            delete.Show();
        }

        private void reschedule_Load(object sender, EventArgs e)
        {
            cnnoledb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ioopdatabase.accdb";
            cnnoledb.Open();

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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            scheduleraflogin afterlogin = new scheduleraflogin();
            this.Hide();
            afterlogin.Show();
        }

        private void classroomcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classroom = (classroomcomboBox.Text).Replace(' ', '_');
            string strSql = "SELECT * FROM " + classroom;
            OleDbConnection connection = new OleDbConnection(cnnoledb.ConnectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, connection);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable timetable = new DataTable();
            da.Fill(timetable);
            classroomdataGridView.DataSource = timetable;
        }
    }
}
