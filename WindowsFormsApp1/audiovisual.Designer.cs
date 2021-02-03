namespace WindowsFormsApp1
{
    partial class audiovisual
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
            this.noradiobutton = new System.Windows.Forms.RadioButton();
            this.yesradiobutton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.additionalsgroupbox = new System.Windows.Forms.GroupBox();
            this.checkBoxprojector = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.additionalsgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // noradiobutton
            // 
            this.noradiobutton.AutoSize = true;
            this.noradiobutton.Location = new System.Drawing.Point(38, 64);
            this.noradiobutton.Name = "noradiobutton";
            this.noradiobutton.Size = new System.Drawing.Size(47, 21);
            this.noradiobutton.TabIndex = 0;
            this.noradiobutton.TabStop = true;
            this.noradiobutton.Text = "No";
            this.noradiobutton.UseVisualStyleBackColor = true;
            this.noradiobutton.CheckedChanged += new System.EventHandler(this.noradiobutton_CheckedChanged);
            // 
            // yesradiobutton
            // 
            this.yesradiobutton.AutoSize = true;
            this.yesradiobutton.Location = new System.Drawing.Point(38, 91);
            this.yesradiobutton.Name = "yesradiobutton";
            this.yesradiobutton.Size = new System.Drawing.Size(53, 21);
            this.yesradiobutton.TabIndex = 1;
            this.yesradiobutton.TabStop = true;
            this.yesradiobutton.Text = "Yes";
            this.yesradiobutton.UseVisualStyleBackColor = true;
            this.yesradiobutton.CheckedChanged += new System.EventHandler(this.yesradiobutton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want any Audio-Visual additionals ?";
            // 
            // additionalsgroupbox
            // 
            this.additionalsgroupbox.Controls.Add(this.checkBoxprojector);
            this.additionalsgroupbox.Controls.Add(this.checkBox2);
            this.additionalsgroupbox.Controls.Add(this.checkBox3);
            this.additionalsgroupbox.Controls.Add(this.checkBox4);
            this.additionalsgroupbox.Enabled = false;
            this.additionalsgroupbox.Location = new System.Drawing.Point(21, 134);
            this.additionalsgroupbox.Name = "additionalsgroupbox";
            this.additionalsgroupbox.Size = new System.Drawing.Size(364, 214);
            this.additionalsgroupbox.TabIndex = 3;
            this.additionalsgroupbox.TabStop = false;
            this.additionalsgroupbox.Text = "Additionals";
            // 
            // checkBoxprojector
            // 
            this.checkBoxprojector.AutoSize = true;
            this.checkBoxprojector.Location = new System.Drawing.Point(6, 32);
            this.checkBoxprojector.Name = "checkBoxprojector";
            this.checkBoxprojector.Size = new System.Drawing.Size(87, 21);
            this.checkBoxprojector.TabIndex = 4;
            this.checkBoxprojector.Text = "Projector";
            this.checkBoxprojector.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "HDMI Cable";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 113);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Sound System";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 153);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(136, 21);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Projector Screen";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(157, 380);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(100, 32);
            this.confirmbutton.TabIndex = 4;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // audiovisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 451);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.additionalsgroupbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yesradiobutton);
            this.Controls.Add(this.noradiobutton);
            this.Name = "audiovisual";
            this.Text = "audiovisual";
            this.Load += new System.EventHandler(this.audiovisual_Load);
            this.additionalsgroupbox.ResumeLayout(false);
            this.additionalsgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton noradiobutton;
        private System.Windows.Forms.RadioButton yesradiobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox additionalsgroupbox;
        private System.Windows.Forms.CheckBox checkBoxprojector;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button confirmbutton;
    }
}