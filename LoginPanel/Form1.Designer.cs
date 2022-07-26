namespace LoginPanel
{
    partial class Form1
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
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTxtb = new System.Windows.Forms.TextBox();
            this.passwordTxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamerequiredLbl = new System.Windows.Forms.Label();
            this.passwordrequiredLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLbl.ForeColor = System.Drawing.Color.Red;
            this.loginLbl.Location = new System.Drawing.Point(155, 82);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(172, 46);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Login";
            this.loginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.ForeColor = System.Drawing.Color.Red;
            this.loginBtn.Location = new System.Drawing.Point(155, 423);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(172, 57);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTxtb
            // 
            this.usernameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTxtb.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTxtb.Location = new System.Drawing.Point(135, 224);
            this.usernameTxtb.Name = "usernameTxtb";
            this.usernameTxtb.Size = new System.Drawing.Size(216, 29);
            this.usernameTxtb.TabIndex = 2;
            this.usernameTxtb.Text = "USERNAME";
            this.usernameTxtb.MouseEnter += new System.EventHandler(this.usernameTxtb_MouseEnter);
            this.usernameTxtb.MouseLeave += new System.EventHandler(this.usernameTxtb_MouseLeave);
            // 
            // passwordTxtb
            // 
            this.passwordTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTxtb.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTxtb.Location = new System.Drawing.Point(135, 314);
            this.passwordTxtb.Name = "passwordTxtb";
            this.passwordTxtb.Size = new System.Drawing.Size(216, 29);
            this.passwordTxtb.TabIndex = 3;
            this.passwordTxtb.Text = "PASSWORD";
            this.passwordTxtb.MouseEnter += new System.EventHandler(this.passwordTxtb_MouseEnter);
            this.passwordTxtb.MouseLeave += new System.EventHandler(this.passwordTxtb_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(131, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password : ";
            // 
            // usernamerequiredLbl
            // 
            this.usernamerequiredLbl.Location = new System.Drawing.Point(135, 260);
            this.usernamerequiredLbl.Name = "usernamerequiredLbl";
            this.usernamerequiredLbl.Size = new System.Drawing.Size(100, 23);
            this.usernamerequiredLbl.TabIndex = 6;
            // 
            // passwordrequiredLbl
            // 
            this.passwordrequiredLbl.Location = new System.Drawing.Point(135, 346);
            this.passwordrequiredLbl.Name = "passwordrequiredLbl";
            this.passwordrequiredLbl.Size = new System.Drawing.Size(100, 23);
            this.passwordrequiredLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(523, 650);
            this.Controls.Add(this.passwordrequiredLbl);
            this.Controls.Add(this.usernamerequiredLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTxtb);
            this.Controls.Add(this.usernameTxtb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTxtb;
        private System.Windows.Forms.TextBox passwordTxtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernamerequiredLbl;
        private System.Windows.Forms.Label passwordrequiredLbl;
    }
}

