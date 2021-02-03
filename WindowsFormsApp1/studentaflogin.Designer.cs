namespace WindowsFormsApp1
{
    partial class studentaflogin
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
            this.logoutbutton = new System.Windows.Forms.Button();
            this.bookingbutton = new System.Windows.Forms.Button();
            this.checkbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(325, 359);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(113, 40);
            this.logoutbutton.TabIndex = 11;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // bookingbutton
            // 
            this.bookingbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingbutton.Location = new System.Drawing.Point(142, 222);
            this.bookingbutton.Name = "bookingbutton";
            this.bookingbutton.Size = new System.Drawing.Size(142, 45);
            this.bookingbutton.TabIndex = 10;
            this.bookingbutton.Text = "Booking";
            this.bookingbutton.UseVisualStyleBackColor = true;
            this.bookingbutton.Click += new System.EventHandler(this.bookingbutton_Click);
            // 
            // checkbutton
            // 
            this.checkbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbutton.Location = new System.Drawing.Point(142, 132);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(142, 45);
            this.checkbutton.TabIndex = 9;
            this.checkbutton.Text = "Check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "What Do You Want To Do?";
            // 
            // studentaflogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 411);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.bookingbutton);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.label1);
            this.Name = "studentaflogin";
            this.Text = "Option";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button bookingbutton;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Label label1;
    }
}