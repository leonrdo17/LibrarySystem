namespace WindowsFormsApp1
{
    partial class schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.classroomcomboBox = new System.Windows.Forms.ComboBox();
            this.availabilitydataGridView = new System.Windows.Forms.DataGridView();
            this.datamodifybutton = new System.Windows.Forms.Button();
            this.bookmodifybutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.requestdataGridView = new System.Windows.Forms.DataGridView();
            this.displaybutton = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classroom:";
            // 
            // classroomcomboBox
            // 
            this.classroomcomboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classroomcomboBox.FormattingEnabled = true;
            this.classroomcomboBox.Location = new System.Drawing.Point(139, 54);
            this.classroomcomboBox.Name = "classroomcomboBox";
            this.classroomcomboBox.Size = new System.Drawing.Size(219, 28);
            this.classroomcomboBox.TabIndex = 2;
            this.classroomcomboBox.SelectedIndexChanged += new System.EventHandler(this.classroomcomboBox_SelectedIndexChanged);
            // 
            // availabilitydataGridView
            // 
            this.availabilitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilitydataGridView.Location = new System.Drawing.Point(24, 101);
            this.availabilitydataGridView.Name = "availabilitydataGridView";
            this.availabilitydataGridView.RowTemplate.Height = 24;
            this.availabilitydataGridView.Size = new System.Drawing.Size(1065, 294);
            this.availabilitydataGridView.TabIndex = 4;
            // 
            // datamodifybutton
            // 
            this.datamodifybutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datamodifybutton.Location = new System.Drawing.Point(24, 401);
            this.datamodifybutton.Name = "datamodifybutton";
            this.datamodifybutton.Size = new System.Drawing.Size(113, 40);
            this.datamodifybutton.TabIndex = 5;
            this.datamodifybutton.Text = "Modify";
            this.datamodifybutton.UseVisualStyleBackColor = true;
            this.datamodifybutton.Click += new System.EventHandler(this.datamodifybutton_Click);
            // 
            // bookmodifybutton
            // 
            this.bookmodifybutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmodifybutton.Location = new System.Drawing.Point(459, 812);
            this.bookmodifybutton.Name = "bookmodifybutton";
            this.bookmodifybutton.Size = new System.Drawing.Size(113, 40);
            this.bookmodifybutton.TabIndex = 6;
            this.bookmodifybutton.Text = "Modify";
            this.bookmodifybutton.UseVisualStyleBackColor = true;
            this.bookmodifybutton.Click += new System.EventHandler(this.bookmodifybutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbutton.Location = new System.Drawing.Point(943, 808);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(113, 40);
            this.returnbutton.TabIndex = 7;
            this.returnbutton.Text = "Finish";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Request";
            // 
            // requestdataGridView
            // 
            this.requestdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestdataGridView.Location = new System.Drawing.Point(24, 522);
            this.requestdataGridView.Name = "requestdataGridView";
            this.requestdataGridView.RowTemplate.Height = 24;
            this.requestdataGridView.Size = new System.Drawing.Size(664, 268);
            this.requestdataGridView.TabIndex = 9;
            // 
            // displaybutton
            // 
            this.displaybutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaybutton.Location = new System.Drawing.Point(575, 469);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(113, 40);
            this.displaybutton.TabIndex = 10;
            this.displaybutton.Text = "Display Req";
            this.displaybutton.UseVisualStyleBackColor = true;
            this.displaybutton.Click += new System.EventHandler(this.displaybutton_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(181, 818);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(186, 30);
            this.idtextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 821);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Scheduling";
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 908);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displaybutton);
            this.Controls.Add(this.requestdataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.bookmodifybutton);
            this.Controls.Add(this.datamodifybutton);
            this.Controls.Add(this.availabilitydataGridView);
            this.Controls.Add(this.classroomcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availabilitydataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classroomcomboBox;
        private System.Windows.Forms.DataGridView availabilitydataGridView;
        private System.Windows.Forms.Button datamodifybutton;
        private System.Windows.Forms.Button bookmodifybutton;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView requestdataGridView;
        private System.Windows.Forms.Button displaybutton;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}