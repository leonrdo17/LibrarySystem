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
    public partial class reschedule : Form
    {
        public reschedule()
        {
            InitializeComponent();
        }

        private void replacebutton_Click(object sender, EventArgs e)
        {
            replacement replacement = new replacement();
            this.Hide();
            replacement.Show();
        }

        private void reschedule_Load(object sender, EventArgs e)
        {
            blocktypecomboBox.Items.Add("Block B");
            blocktypecomboBox.Items.Add("Block D");
            blocktypecomboBox.Items.Add("Block E");
            typeofclasscomboBox.Items.Add("Auditorium");
            typeofclasscomboBox.Items.Add("Computer Lab");
            typeofclasscomboBox.Items.Add("Egineering Lab");
            typeofclasscomboBox.Items.Add("Regular Class");
        }
    }
}
