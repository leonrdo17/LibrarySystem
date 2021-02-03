namespace WindowsFormsApp1
{
    partial class scheduleraflogin
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
            this.schedulebutton = new System.Windows.Forms.Button();
            this.reschedulebutton = new System.Windows.Forms.Button();
            this.erasebutton = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Do You Want To Do?";
            // 
            // schedulebutton
            // 
            this.schedulebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulebutton.Location = new System.Drawing.Point(148, 133);
            this.schedulebutton.Name = "schedulebutton";
            this.schedulebutton.Size = new System.Drawing.Size(142, 45);
            this.schedulebutton.TabIndex = 2;
            this.schedulebutton.Text = "Shedule";
            this.schedulebutton.UseVisualStyleBackColor = true;
            this.schedulebutton.Click += new System.EventHandler(this.schedulebutton_Click);
            // 
            // reschedulebutton
            // 
            this.reschedulebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reschedulebutton.Location = new System.Drawing.Point(148, 212);
            this.reschedulebutton.Name = "reschedulebutton";
            this.reschedulebutton.Size = new System.Drawing.Size(145, 45);
            this.reschedulebutton.TabIndex = 3;
            this.reschedulebutton.Text = "Move";
            this.reschedulebutton.UseVisualStyleBackColor = true;
            this.reschedulebutton.Click += new System.EventHandler(this.reschedulebutton_Click);
            // 
            // erasebutton
            // 
            this.erasebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erasebutton.Location = new System.Drawing.Point(148, 297);
            this.erasebutton.Name = "erasebutton";
            this.erasebutton.Size = new System.Drawing.Size(145, 45);
            this.erasebutton.TabIndex = 4;
            this.erasebutton.Text = "Cancel";
            this.erasebutton.UseVisualStyleBackColor = true;
            this.erasebutton.Click += new System.EventHandler(this.erasebutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(326, 362);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(113, 40);
            this.logoutbutton.TabIndex = 5;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // scheduleraflogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 414);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.erasebutton);
            this.Controls.Add(this.reschedulebutton);
            this.Controls.Add(this.schedulebutton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "scheduleraflogin";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button schedulebutton;
        private System.Windows.Forms.Button reschedulebutton;
        private System.Windows.Forms.Button erasebutton;
        private System.Windows.Forms.Button logoutbutton;
    }
}