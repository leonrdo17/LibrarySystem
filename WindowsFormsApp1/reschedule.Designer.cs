namespace WindowsFormsApp1
{
    partial class reschedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeofclasscomboBox = new System.Windows.Forms.ComboBox();
            this.blocktypecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnbutton = new System.Windows.Forms.Button();
            this.displaybutton = new System.Windows.Forms.Button();
            this.replacebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeofclasscomboBox
            // 
            this.typeofclasscomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofclasscomboBox.FormattingEnabled = true;
            this.typeofclasscomboBox.Location = new System.Drawing.Point(458, 40);
            this.typeofclasscomboBox.Name = "typeofclasscomboBox";
            this.typeofclasscomboBox.Size = new System.Drawing.Size(186, 28);
            this.typeofclasscomboBox.TabIndex = 15;
            // 
            // blocktypecomboBox
            // 
            this.blocktypecomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocktypecomboBox.FormattingEnabled = true;
            this.blocktypecomboBox.Location = new System.Drawing.Point(123, 37);
            this.blocktypecomboBox.Name = "blocktypecomboBox";
            this.blocktypecomboBox.Size = new System.Drawing.Size(186, 28);
            this.blocktypecomboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type Of Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Block Type:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(636, 189);
            this.dataGridView1.TabIndex = 20;
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(486, 358);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 23;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            // 
            // displaybutton
            // 
            this.displaybutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaybutton.Location = new System.Drawing.Point(271, 358);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(113, 40);
            this.displaybutton.TabIndex = 22;
            this.displaybutton.Text = "Display";
            this.displaybutton.UseVisualStyleBackColor = true;
            // 
            // replacebutton
            // 
            this.replacebutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacebutton.Location = new System.Drawing.Point(48, 358);
            this.replacebutton.Name = "replacebutton";
            this.replacebutton.Size = new System.Drawing.Size(113, 40);
            this.replacebutton.TabIndex = 21;
            this.replacebutton.Text = "Replace";
            this.replacebutton.UseVisualStyleBackColor = true;
            this.replacebutton.Click += new System.EventHandler(this.replacebutton_Click);
            // 
            // reschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 420);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.displaybutton);
            this.Controls.Add(this.replacebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typeofclasscomboBox);
            this.Controls.Add(this.blocktypecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "reschedule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.reschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox typeofclasscomboBox;
        private System.Windows.Forms.ComboBox blocktypecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button displaybutton;
        private System.Windows.Forms.Button replacebutton;
    }
}