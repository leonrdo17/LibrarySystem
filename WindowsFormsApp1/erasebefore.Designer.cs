namespace WindowsFormsApp1
{
    partial class erasebefore
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
            this.returnbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.availabilitydataGridView = new System.Windows.Forms.DataGridView();
            this.classroomcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(514, 353);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 17;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(26, 353);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(113, 40);
            this.nextbutton.TabIndex = 15;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // availabilitydataGridView
            // 
            this.availabilitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilitydataGridView.Location = new System.Drawing.Point(26, 97);
            this.availabilitydataGridView.Name = "availabilitydataGridView";
            this.availabilitydataGridView.RowTemplate.Height = 24;
            this.availabilitydataGridView.Size = new System.Drawing.Size(601, 214);
            this.availabilitydataGridView.TabIndex = 14;
            // 
            // classroomcomboBox
            // 
            this.classroomcomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomcomboBox.FormattingEnabled = true;
            this.classroomcomboBox.Location = new System.Drawing.Point(126, 49);
            this.classroomcomboBox.Name = "classroomcomboBox";
            this.classroomcomboBox.Size = new System.Drawing.Size(186, 28);
            this.classroomcomboBox.TabIndex = 12;
            this.classroomcomboBox.SelectedIndexChanged += new System.EventHandler(this.classroomcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Classroom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cancel Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // erasebefore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.availabilitydataGridView);
            this.Controls.Add(this.classroomcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "erasebefore";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.erasebefore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.DataGridView availabilitydataGridView;
        private System.Windows.Forms.ComboBox classroomcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}