namespace Program.UI
{
    partial class AddMealScreen
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
            grpMeals = new GroupBox();
            lstMeals = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            gbxAddMeal = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtMealName = new TextBox();
            grpMeals.SuspendLayout();
            gbxAddMeal.SuspendLayout();
            SuspendLayout();
            // 
            // grpMeals
            // 
            grpMeals.Controls.Add(lstMeals);
            grpMeals.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpMeals.Location = new Point(351, 12);
            grpMeals.Name = "grpMeals";
            grpMeals.Size = new Size(521, 533);
            grpMeals.TabIndex = 10;
            grpMeals.TabStop = false;
            grpMeals.Text = "Meals";
            // 
            // lstMeals
            // 
            lstMeals.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader7 });
            lstMeals.FullRowSelect = true;
            lstMeals.GridLines = true;
            lstMeals.Location = new Point(6, 21);
            lstMeals.Name = "lstMeals";
            lstMeals.Size = new Size(509, 506);
            lstMeals.TabIndex = 5;
            lstMeals.UseCompatibleStateImageBehavior = false;
            lstMeals.View = View.Details;
            lstMeals.SelectedIndexChanged += lstMeals_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Is Active";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Created Date";
            columnHeader5.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Deleted Date";
            columnHeader7.Width = 120;
            // 
            // gbxAddMeal
            // 
            gbxAddMeal.Controls.Add(btnDelete);
            gbxAddMeal.Controls.Add(btnUpdate);
            gbxAddMeal.Controls.Add(btnAdd);
            gbxAddMeal.Controls.Add(label1);
            gbxAddMeal.Controls.Add(txtMealName);
            gbxAddMeal.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAddMeal.Location = new Point(12, 177);
            gbxAddMeal.Name = "gbxAddMeal";
            gbxAddMeal.Size = new Size(315, 148);
            gbxAddMeal.TabIndex = 9;
            gbxAddMeal.TabStop = false;
            gbxAddMeal.Text = "Add Meal";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(9, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 47);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(115, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 47);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(219, 95);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 47);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 1;
            label1.Text = "Meal Name:";
            // 
            // txtMealName
            // 
            txtMealName.Location = new Point(115, 21);
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(170, 27);
            txtMealName.TabIndex = 0;
            // 
            // AddMealScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 557);
            Controls.Add(grpMeals);
            Controls.Add(gbxAddMeal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMealScreen";
            Text = "AddMealScreen";
            Load += AddMealScreen_Load;
            grpMeals.ResumeLayout(false);
            gbxAddMeal.ResumeLayout(false);
            gbxAddMeal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMeals;
        private ListView lstMeals;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
        private GroupBox gbxAddMeal;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private TextBox txtMealName;
    }
}