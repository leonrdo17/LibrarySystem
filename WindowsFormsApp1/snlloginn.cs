﻿using System;
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
    public partial class snlloginn : Form
    {
        public snlloginn()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            idtextBox.Clear();
            passwordtextBox.Clear();
        }
    }
}
