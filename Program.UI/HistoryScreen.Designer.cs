namespace Program.UI
{
    partial class HistoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryScreen));
            btnDeleteDay = new Button();
            btnDeleteMeal = new Button();
            lvMeals = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            lvDays = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnDeleteDay
            // 
            btnDeleteDay.FlatAppearance.BorderSize = 0;
            btnDeleteDay.FlatStyle = FlatStyle.Flat;
            btnDeleteDay.Image = (Image)resources.GetObject("btnDeleteDay.Image");
            btnDeleteDay.Location = new Point(690, 456);
            btnDeleteDay.Margin = new Padding(3, 2, 3, 2);
            btnDeleteDay.Name = "btnDeleteDay";
            btnDeleteDay.Size = new Size(157, 90);
            btnDeleteDay.TabIndex = 8;
            btnDeleteDay.Text = "DELETE DAY";
            btnDeleteDay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteDay.UseVisualStyleBackColor = true;
            btnDeleteDay.Click += btnDeleteDay_Click;
            // 
            // btnDeleteMeal
            // 
            btnDeleteMeal.BackColor = SystemColors.Control;
            btnDeleteMeal.FlatAppearance.BorderSize = 0;
            btnDeleteMeal.FlatStyle = FlatStyle.Flat;
            btnDeleteMeal.Image = (Image)resources.GetObject("btnDeleteMeal.Image");
            btnDeleteMeal.Location = new Point(403, 456);
            btnDeleteMeal.Margin = new Padding(3, 2, 3, 2);
            btnDeleteMeal.Name = "btnDeleteMeal";
            btnDeleteMeal.Size = new Size(171, 90);
            btnDeleteMeal.TabIndex = 7;
            btnDeleteMeal.Text = "DELETE MEAL";
            btnDeleteMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteMeal.UseVisualStyleBackColor = false;
            btnDeleteMeal.Click += btnDeleteMeal_Click;
            // 
            // lvMeals
            // 
            lvMeals.BorderStyle = BorderStyle.None;
            lvMeals.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2, columnHeader9, columnHeader3, columnHeader5, columnHeader8, columnHeader6 });
            lvMeals.FullRowSelect = true;
            lvMeals.GridLines = true;
            lvMeals.Location = new Point(18, 60);
            lvMeals.Margin = new Padding(3, 2, 3, 2);
            lvMeals.Name = "lvMeals";
            lvMeals.Size = new Size(556, 377);
            lvMeals.TabIndex = 6;
            lvMeals.UseCompatibleStateImageBehavior = false;
            lvMeals.View = View.Details;
            lvMeals.Click += lvMeals_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Index";
            columnHeader4.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Category";
            columnHeader9.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Calorie/Unit";
            columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Quantity";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Total Calorie";
            columnHeader8.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Portion Type";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            columnHeader6.Width = 105;
            // 
            // lvDays
            // 
            lvDays.BorderStyle = BorderStyle.None;
            lvDays.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader10 });
            lvDays.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lvDays.Location = new Point(591, 60);
            lvDays.Margin = new Padding(3, 2, 3, 2);
            lvDays.MultiSelect = false;
            lvDays.Name = "lvDays";
            lvDays.Size = new Size(275, 377);
            lvDays.TabIndex = 5;
            lvDays.UseCompatibleStateImageBehavior = false;
            lvDays.View = View.Details;
            lvDays.SelectedIndexChanged += lvDays_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Dates";
            columnHeader1.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Total Calories";
            columnHeader10.Width = 120;
            // 
            // HistoryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 557);
            Controls.Add(btnDeleteDay);
            Controls.Add(btnDeleteMeal);
            Controls.Add(lvMeals);
            Controls.Add(lvDays);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoryScreen";
            Text = "HistoryScreen";
            Load += HistoryScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteDay;
        private Button btnDeleteMeal;
        private ListView lvMeals;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader6;
        private ListView lvDays;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader10;
    }
}