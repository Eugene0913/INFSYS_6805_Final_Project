namespace CalorieCounter
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.lblCountCalsNow = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbFoodCategories = new System.Windows.Forms.ComboBox();
            this.lblFoodCategory = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.cbFoods = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnAddFoodItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountCalsNow
            // 
            this.lblCountCalsNow.AutoSize = true;
            this.lblCountCalsNow.BackColor = System.Drawing.Color.Transparent;
            this.lblCountCalsNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCalsNow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountCalsNow.Location = new System.Drawing.Point(42, 9);
            this.lblCountCalsNow.Name = "lblCountCalsNow";
            this.lblCountCalsNow.Size = new System.Drawing.Size(1290, 111);
            this.lblCountCalsNow.TabIndex = 3;
            this.lblCountCalsNow.Text = "Count Cals Now: Add Food";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMainMenu.Location = new System.Drawing.Point(344, 766);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(770, 85);
            this.btnMainMenu.TabIndex = 13;
            this.btnMainMenu.Text = "Return to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnExit.Location = new System.Drawing.Point(452, 869);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(497, 83);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbFoodCategories
            // 
            this.cbFoodCategories.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoodCategories.FormattingEnabled = true;
            this.cbFoodCategories.Location = new System.Drawing.Point(829, 286);
            this.cbFoodCategories.Name = "cbFoodCategories";
            this.cbFoodCategories.Size = new System.Drawing.Size(445, 83);
            this.cbFoodCategories.TabIndex = 14;
            this.cbFoodCategories.SelectedIndexChanged += new System.EventHandler(this.cbFoodCategories_SelectedIndexChanged);
            // 
            // lblFoodCategory
            // 
            this.lblFoodCategory.AutoSize = true;
            this.lblFoodCategory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCategory.ForeColor = System.Drawing.Color.Transparent;
            this.lblFoodCategory.Location = new System.Drawing.Point(97, 290);
            this.lblFoodCategory.Name = "lblFoodCategory";
            this.lblFoodCategory.Size = new System.Drawing.Size(726, 75);
            this.lblFoodCategory.TabIndex = 15;
            this.lblFoodCategory.Text = "Select Food Category:";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.Transparent;
            this.lblFood.Location = new System.Drawing.Point(97, 409);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(422, 75);
            this.lblFood.TabIndex = 17;
            this.lblFood.Text = "Select Food:";
            // 
            // cbFoods
            // 
            this.cbFoods.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.Location = new System.Drawing.Point(525, 405);
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(749, 83);
            this.cbFoods.TabIndex = 16;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(97, 534);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(494, 75);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Input Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(597, 530);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(677, 82);
            this.tbQuantity.TabIndex = 19;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // btnAddFoodItem
            // 
            this.btnAddFoodItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddFoodItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAddFoodItem.Location = new System.Drawing.Point(344, 661);
            this.btnAddFoodItem.Name = "btnAddFoodItem";
            this.btnAddFoodItem.Size = new System.Drawing.Size(770, 85);
            this.btnAddFoodItem.TabIndex = 20;
            this.btnAddFoodItem.Text = "Add Item";
            this.btnAddFoodItem.UseVisualStyleBackColor = false;
            this.btnAddFoodItem.Click += new System.EventHandler(this.btnAddFoodItem_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 1079);
            this.Controls.Add(this.btnAddFoodItem);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.cbFoods);
            this.Controls.Add(this.lblFoodCategory);
            this.Controls.Add(this.cbFoodCategories);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCountCalsNow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 1150);
            this.MinimumSize = new System.Drawing.Size(1400, 1150);
            this.Name = "frmAddItem";
            this.Text = "Add Food";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountCalsNow;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbFoodCategories;
        private System.Windows.Forms.Label lblFoodCategory;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.ComboBox cbFoods;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnAddFoodItem;
    }
}