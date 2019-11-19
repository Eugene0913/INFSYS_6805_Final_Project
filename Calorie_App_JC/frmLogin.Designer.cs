namespace CalorieCounter
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblCountCalsNow = new System.Windows.Forms.Label();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountCalsNow
            // 
            this.lblCountCalsNow.AutoSize = true;
            this.lblCountCalsNow.BackColor = System.Drawing.Color.Transparent;
            this.lblCountCalsNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCalsNow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountCalsNow.Location = new System.Drawing.Point(93, 9);
            this.lblCountCalsNow.Name = "lblCountCalsNow";
            this.lblCountCalsNow.Size = new System.Drawing.Size(789, 111);
            this.lblCountCalsNow.TabIndex = 1;
            this.lblCountCalsNow.Text = "Count Cals Now";
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbLoginEmail.Location = new System.Drawing.Point(189, 243);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(616, 82);
            this.tbLoginEmail.TabIndex = 2;
            this.tbLoginEmail.Text = "Email@email.com";
            this.tbLoginEmail.Click += new System.EventHandler(this.tbLoginEmail_Click);
            this.tbLoginEmail.Leave += new System.EventHandler(this.tbLoginEmail_Leave);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbLoginPassword.Location = new System.Drawing.Point(189, 356);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.Size = new System.Drawing.Size(616, 82);
            this.tbLoginPassword.TabIndex = 3;
            this.tbLoginPassword.Text = "Password";
            this.tbLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSignUp.Location = new System.Drawing.Point(112, 635);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(375, 97);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.Location = new System.Drawing.Point(215, 831);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(497, 83);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLogin.Location = new System.Drawing.Point(507, 635);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(375, 97);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(974, 1179);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.lblCountCalsNow);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 1250);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count Cals Now";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountCalsNow;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
    }
}

