namespace WindowsFormsApp1
{
    partial class opening
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
            this.label2 = new System.Windows.Forms.Label();
            this.schedulerbutton = new System.Windows.Forms.Button();
            this.lecturerbutton = new System.Windows.Forms.Button();
            this.studentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose your Login Type:";
            // 
            // schedulerbutton
            // 
            this.schedulerbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulerbutton.Location = new System.Drawing.Point(150, 162);
            this.schedulerbutton.Name = "schedulerbutton";
            this.schedulerbutton.Size = new System.Drawing.Size(142, 45);
            this.schedulerbutton.TabIndex = 2;
            this.schedulerbutton.Text = "Scheduler";
            this.schedulerbutton.UseVisualStyleBackColor = true;
            this.schedulerbutton.Click += new System.EventHandler(this.schedulerbutton_Click);
            // 
            // lecturerbutton
            // 
            this.lecturerbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerbutton.Location = new System.Drawing.Point(150, 233);
            this.lecturerbutton.Name = "lecturerbutton";
            this.lecturerbutton.Size = new System.Drawing.Size(142, 45);
            this.lecturerbutton.TabIndex = 3;
            this.lecturerbutton.Text = "Lecturer";
            this.lecturerbutton.UseVisualStyleBackColor = true;
            this.lecturerbutton.Click += new System.EventHandler(this.lecturerbutton_Click);
            // 
            // studentbutton
            // 
            this.studentbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbutton.Location = new System.Drawing.Point(150, 310);
            this.studentbutton.Name = "studentbutton";
            this.studentbutton.Size = new System.Drawing.Size(145, 45);
            this.studentbutton.TabIndex = 4;
            this.studentbutton.Text = "Student";
            this.studentbutton.UseVisualStyleBackColor = true;
            this.studentbutton.Click += new System.EventHandler(this.studentbutton_Click);
            // 
            // opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 411);
            this.Controls.Add(this.studentbutton);
            this.Controls.Add(this.lecturerbutton);
            this.Controls.Add(this.schedulerbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "opening";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button schedulerbutton;
        private System.Windows.Forms.Button lecturerbutton;
        private System.Windows.Forms.Button studentbutton;
    }
}

