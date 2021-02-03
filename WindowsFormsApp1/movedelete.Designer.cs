namespace WindowsFormsApp1
{
    partial class movedelete
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
            this.timecomboBox = new System.Windows.Forms.ComboBox();
            this.datecomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.returnbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classroomcomboBox = new System.Windows.Forms.ComboBox();
            this.erasebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timecomboBox
            // 
            this.timecomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timecomboBox.FormattingEnabled = true;
            this.timecomboBox.Location = new System.Drawing.Point(206, 235);
            this.timecomboBox.Name = "timecomboBox";
            this.timecomboBox.Size = new System.Drawing.Size(186, 28);
            this.timecomboBox.TabIndex = 24;
            // 
            // datecomboBox
            // 
            this.datecomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datecomboBox.FormattingEnabled = true;
            this.datecomboBox.Location = new System.Drawing.Point(206, 192);
            this.datecomboBox.Name = "datecomboBox";
            this.datecomboBox.Size = new System.Drawing.Size(186, 28);
            this.datecomboBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date:";
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(303, 386);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 29;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 35);
            this.label7.TabIndex = 32;
            this.label7.Text = "Removed Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Classroom:";
            // 
            // classroomcomboBox
            // 
            this.classroomcomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomcomboBox.FormattingEnabled = true;
            this.classroomcomboBox.Location = new System.Drawing.Point(206, 144);
            this.classroomcomboBox.Name = "classroomcomboBox";
            this.classroomcomboBox.Size = new System.Drawing.Size(186, 28);
            this.classroomcomboBox.TabIndex = 34;
            // 
            // erasebutton
            // 
            this.erasebutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erasebutton.Location = new System.Drawing.Point(21, 386);
            this.erasebutton.Name = "erasebutton";
            this.erasebutton.Size = new System.Drawing.Size(113, 40);
            this.erasebutton.TabIndex = 35;
            this.erasebutton.Text = "Next";
            this.erasebutton.UseVisualStyleBackColor = true;
            this.erasebutton.Click += new System.EventHandler(this.erasebutton_Click);
            // 
            // movedelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 438);
            this.Controls.Add(this.erasebutton);
            this.Controls.Add(this.classroomcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.timecomboBox);
            this.Controls.Add(this.datecomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "movedelete";
            this.Text = "Move";
            this.Load += new System.EventHandler(this.movedelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox timecomboBox;
        private System.Windows.Forms.ComboBox datecomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classroomcomboBox;
        private System.Windows.Forms.Button erasebutton;
    }
}