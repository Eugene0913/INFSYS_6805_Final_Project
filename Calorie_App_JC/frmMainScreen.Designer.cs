namespace CalorieCounter
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.lblCountCalsNow = new System.Windows.Forms.Label();
            this.chrtTrending = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calorieCounterDataSet = new CalorieCounter.CalorieCounterDataSet();
            this.calorieCounterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTrending = new System.Windows.Forms.ComboBox();
            this.lblTrending = new System.Windows.Forms.Label();
            this.gbNavigation = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btDeleteItem = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTrending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieCounterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieCounterDataSetBindingSource)).BeginInit();
            this.gbNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountCalsNow
            // 
            this.lblCountCalsNow.AutoSize = true;
            this.lblCountCalsNow.BackColor = System.Drawing.Color.Transparent;
            this.lblCountCalsNow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCalsNow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCountCalsNow.Location = new System.Drawing.Point(593, 0);
            this.lblCountCalsNow.Name = "lblCountCalsNow";
            this.lblCountCalsNow.Size = new System.Drawing.Size(789, 111);
            this.lblCountCalsNow.TabIndex = 2;
            this.lblCountCalsNow.Text = "Count Cals Now";
            // 
            // chrtTrending
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtTrending.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chrtTrending.Legends.Add(legend1);
            this.chrtTrending.Location = new System.Drawing.Point(31, 124);
            this.chrtTrending.Name = "chrtTrending";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtTrending.Series.Add(series1);
            this.chrtTrending.Size = new System.Drawing.Size(1408, 496);
            this.chrtTrending.TabIndex = 3;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "tltTrending";
            title1.Text = "Calories Trending";
            this.chrtTrending.Titles.Add(title1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 626);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1408, 482);
            this.dataGridView1.TabIndex = 4;
            // 
            // calorieCounterDataSet
            // 
            this.calorieCounterDataSet.DataSetName = "CalorieCounterDataSet";
            this.calorieCounterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calorieCounterDataSetBindingSource
            // 
            this.calorieCounterDataSetBindingSource.DataSource = this.calorieCounterDataSet;
            this.calorieCounterDataSetBindingSource.Position = 0;
            // 
            // cbTrending
            // 
            this.cbTrending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrending.FormattingEnabled = true;
            this.cbTrending.Items.AddRange(new object[] {
            "Overall",
            "Meal"});
            this.cbTrending.Location = new System.Drawing.Point(1667, 127);
            this.cbTrending.Name = "cbTrending";
            this.cbTrending.Size = new System.Drawing.Size(295, 50);
            this.cbTrending.TabIndex = 5;
            // 
            // lblTrending
            // 
            this.lblTrending.AutoSize = true;
            this.lblTrending.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrending.Location = new System.Drawing.Point(1457, 124);
            this.lblTrending.Name = "lblTrending";
            this.lblTrending.Size = new System.Drawing.Size(204, 51);
            this.lblTrending.TabIndex = 6;
            this.lblTrending.Text = "Show By:";
            // 
            // gbNavigation
            // 
            this.gbNavigation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbNavigation.Controls.Add(this.btnExit);
            this.gbNavigation.Controls.Add(this.btnLogOut);
            this.gbNavigation.Controls.Add(this.btDeleteItem);
            this.gbNavigation.Controls.Add(this.btnAddFood);
            this.gbNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNavigation.Location = new System.Drawing.Point(1454, 578);
            this.gbNavigation.Name = "gbNavigation";
            this.gbNavigation.Size = new System.Drawing.Size(508, 530);
            this.gbNavigation.TabIndex = 7;
            this.gbNavigation.TabStop = false;
            this.gbNavigation.Text = "Main Menu Options";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(12, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(479, 81);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(12, 300);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(479, 81);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btDeleteItem
            // 
            this.btDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btDeleteItem.Location = new System.Drawing.Point(12, 188);
            this.btDeleteItem.Name = "btDeleteItem";
            this.btDeleteItem.Size = new System.Drawing.Size(479, 81);
            this.btDeleteItem.TabIndex = 1;
            this.btDeleteItem.Text = "Delete Food Item";
            this.btDeleteItem.UseVisualStyleBackColor = true;
            this.btDeleteItem.Click += new System.EventHandler(this.btDeleteItem_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.ForeColor = System.Drawing.Color.Black;
            this.btnAddFood.Location = new System.Drawing.Point(12, 76);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(479, 81);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Add Food Item";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1974, 1429);
            this.Controls.Add(this.gbNavigation);
            this.Controls.Add(this.lblTrending);
            this.Controls.Add(this.cbTrending);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chrtTrending);
            this.Controls.Add(this.lblCountCalsNow);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(2000, 1500);
            this.Name = "frmMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.chrtTrending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieCounterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorieCounterDataSetBindingSource)).EndInit();
            this.gbNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountCalsNow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTrending;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource calorieCounterDataSetBindingSource;
        private CalorieCounterDataSet calorieCounterDataSet;
        private System.Windows.Forms.ComboBox cbTrending;
        private System.Windows.Forms.Label lblTrending;
        private System.Windows.Forms.GroupBox gbNavigation;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btDeleteItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}