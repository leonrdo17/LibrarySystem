namespace WindowsFormsApp1
{
    partial class move
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
            this.classroomdataGridView = new System.Windows.Forms.DataGridView();
            this.returnbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classroomdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classroomcomboBox
            // 
            this.classroomcomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomcomboBox.FormattingEnabled = true;
            this.classroomcomboBox.Location = new System.Drawing.Point(119, 59);
            this.classroomcomboBox.Name = "classroomcomboBox";
            this.classroomcomboBox.Size = new System.Drawing.Size(186, 28);
            this.classroomcomboBox.TabIndex = 14;
            this.classroomcomboBox.SelectedIndexChanged += new System.EventHandler(this.classroomcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Classroom:";
            // 
            // classroomdataGridView
            // 
            this.classroomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroomdataGridView.Location = new System.Drawing.Point(12, 103);
            this.classroomdataGridView.Name = "classroomdataGridView";
            this.classroomdataGridView.RowTemplate.Height = 24;
            this.classroomdataGridView.Size = new System.Drawing.Size(636, 284);
            this.classroomdataGridView.TabIndex = 20;
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(473, 406);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 23;
            this.returnbutton.Text = "Return";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(35, 406);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(113, 40);
            this.nextbutton.TabIndex = 21;
            this.nextbutton.Text = "Next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Move Information";
            // 
            // move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.classroomdataGridView);
            this.Controls.Add(this.classroomcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "move";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.reschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classroomdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox classroomcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView classroomdataGridView;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label label2;
    }
}