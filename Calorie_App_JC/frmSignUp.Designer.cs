namespace CalorieCounter
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCountCalsNow = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(43, 232);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(392, 75);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
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
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(50, 387);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(385, 75);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(211, 534);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(224, 75);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(73, 685);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(362, 75);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.Location = new System.Drawing.Point(220, 1046);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(497, 83);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCreateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCreateAccount.Location = new System.Drawing.Point(112, 836);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(770, 85);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Silver;
            this.tbFirstName.Location = new System.Drawing.Point(429, 232);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(533, 82);
            this.tbFirstName.TabIndex = 7;
            this.tbFirstName.Text = "First Name";
            this.tbFirstName.Click += new System.EventHandler(this.tbFirstName_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.Silver;
            this.tbLastName.Location = new System.Drawing.Point(429, 387);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(533, 82);
            this.tbLastName.TabIndex = 8;
            this.tbLastName.Text = "Last Name";
            this.tbLastName.Click += new System.EventHandler(this.tbLastName_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbEmail.Location = new System.Drawing.Point(429, 534);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(533, 82);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Text = "Email";
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(429, 685);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(533, 82);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMainMenu.Location = new System.Drawing.Point(112, 943);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(770, 85);
            this.btnMainMenu.TabIndex = 11;
            this.btnMainMenu.Text = "Return to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(974, 1179);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCountCalsNow);
            this.Controls.Add(this.lblFirstName);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 1250);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCountCalsNow;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnMainMenu;
    }
}