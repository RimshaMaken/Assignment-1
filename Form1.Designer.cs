namespace Assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 48);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 0;
            label1.Text = "Interactive Password Field";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtPassword);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(71, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 116);
            panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(43, 31);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(490, 31);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Click += txtPassword_Click;
            txtPassword.DoubleClick += txtPassword_DoubleClick;
            txtPassword.MouseDown += txtPassword_MouseDown;
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 269);
            label2.Name = "label2";
            label2.Size = new Size(343, 150);
            label2.TabIndex = 2;
            label2.Text = "Interactive Features:\r\n. Hover - Reveal password\r\n. Right-Click - Generate random password\r\n. Left-Click - Copy to Clipboard\r\n. Double-Click - Clear password\r\n\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Password Field Demo - Interactive Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtPassword;
        private Label label2;
    }
}
