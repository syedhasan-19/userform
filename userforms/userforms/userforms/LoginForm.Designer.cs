namespace userforms
{
    partial class LoginForm
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
            this.Signuplbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Signuplbl
            // 
            this.Signuplbl.AutoSize = true;
            this.Signuplbl.Location = new System.Drawing.Point(338, 290);
            this.Signuplbl.Name = "Signuplbl";
            this.Signuplbl.Size = new System.Drawing.Size(101, 13);
            this.Signuplbl.TabIndex = 31;
            this.Signuplbl.Text = "Create an account?";
            this.Signuplbl.Click += new System.EventHandler(this.Signuplbl_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(346, 222);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 29;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "LOGIN PAGE";
            // 
            // PassTBox
            // 
            this.PassTBox.Location = new System.Drawing.Point(362, 175);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(100, 20);
            this.PassTBox.TabIndex = 27;
            // 
            // UserTBox
            // 
            this.UserTBox.Location = new System.Drawing.Point(362, 135);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(100, 20);
            this.UserTBox.TabIndex = 26;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(298, 178);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 25;
            this.passwordlbl.Text = "Password";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(298, 138);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(58, 13);
            this.userlbl.TabIndex = 24;
            this.userlbl.Text = "Username:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Signuplbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userlbl);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Signuplbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.TextBox UserTBox;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label userlbl;
    }
}