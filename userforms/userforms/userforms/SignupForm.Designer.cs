namespace userforms
{
    partial class SignupForm
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
            this.Loginlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginlbl
            // 
            this.Loginlbl.AutoSize = true;
            this.Loginlbl.Location = new System.Drawing.Point(307, 292);
            this.Loginlbl.Name = "Loginlbl";
            this.Loginlbl.Size = new System.Drawing.Size(132, 13);
            this.Loginlbl.TabIndex = 15;
            this.Loginlbl.Text = "Already have an account?";
            this.Loginlbl.Click += new System.EventHandler(this.Loginlbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.Control;
            this.signupbtn.Location = new System.Drawing.Point(330, 220);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(75, 23);
            this.signupbtn.TabIndex = 13;
            this.signupbtn.Text = "SIGN UP";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "SIGN UP PAGE";
            // 
            // PassTBox
            // 
            this.PassTBox.Location = new System.Drawing.Point(346, 173);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(100, 20);
            this.PassTBox.TabIndex = 11;
            // 
            // UserTBox
            // 
            this.UserTBox.Location = new System.Drawing.Point(346, 133);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.Size = new System.Drawing.Size(100, 20);
            this.UserTBox.TabIndex = 10;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(282, 176);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 9;
            this.passwordlbl.Text = "Password";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(282, 136);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(58, 13);
            this.userlbl.TabIndex = 8;
            this.userlbl.Text = "Username:";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loginlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userlbl);
            this.Name = "SignupForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loginlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTBox;
        private System.Windows.Forms.TextBox UserTBox;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label userlbl;
    }
}

