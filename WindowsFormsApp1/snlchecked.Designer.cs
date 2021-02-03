namespace WindowsFormsApp1
{
    partial class snlchecked
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
            this.classroomcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availabilitydataGridView = new System.Windows.Forms.DataGridView();
            this.returnbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classroomcomboBox
            // 
            this.classroomcomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomcomboBox.FormattingEnabled = true;
            this.classroomcomboBox.Location = new System.Drawing.Point(130, 68);
            this.classroomcomboBox.Name = "classroomcomboBox";
            this.classroomcomboBox.Size = new System.Drawing.Size(186, 28);
            this.classroomcomboBox.TabIndex = 18;
            this.classroomcomboBox.SelectedIndexChanged += new System.EventHandler(this.classroomcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Classroom:";
            // 
            // availabilitydataGridView
            // 
            this.availabilitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilitydataGridView.Location = new System.Drawing.Point(15, 123);
            this.availabilitydataGridView.Name = "availabilitydataGridView";
            this.availabilitydataGridView.RowTemplate.Height = 24;
            this.availabilitydataGridView.Size = new System.Drawing.Size(1181, 489);
            this.availabilitydataGridView.TabIndex = 20;
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(1094, 632);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 25;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Availability Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // snlchecked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.availabilitydataGridView);
            this.Controls.Add(this.classroomcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "snlchecked";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.snlchecked_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox classroomcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView availabilitydataGridView;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Label label2;
    }
}