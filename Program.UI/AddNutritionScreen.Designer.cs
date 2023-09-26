namespace Program.UI
{
    partial class AddNutritionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNutritionScreen));
            grpMeals = new GroupBox();
            lstNutrinions = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            gbxAddNutrition = new GroupBox();
            label5 = new Label();
            txtMeasurement = new TextBox();
            pbNutritionImage = new PictureBox();
            label4 = new Label();
            cbCategory = new ComboBox();
            label3 = new Label();
            cbPortionType = new ComboBox();
            label2 = new Label();
            txtCalorie = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtNutritionName = new TextBox();
            grpMeals.SuspendLayout();
            gbxAddNutrition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).BeginInit();
            SuspendLayout();
            // 
            // grpMeals
            // 
            grpMeals.Controls.Add(lstNutrinions);
            grpMeals.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grpMeals.Location = new Point(396, 12);
            grpMeals.Name = "grpMeals";
            grpMeals.Size = new Size(476, 464);
            grpMeals.TabIndex = 12;
            grpMeals.TabStop = false;
            grpMeals.Text = "Nutrinions";
            // 
            // lstNutrinions
            // 
            lstNutrinions.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader3, columnHeader6, columnHeader7 });
            lstNutrinions.FullRowSelect = true;
            lstNutrinions.GridLines = true;
            lstNutrinions.Location = new Point(6, 21);
            lstNutrinions.Name = "lstNutrinions";
            lstNutrinions.Size = new Size(464, 437);
            lstNutrinions.TabIndex = 5;
            lstNutrinions.UseCompatibleStateImageBehavior = false;
            lstNutrinions.View = View.Details;
            lstNutrinions.SelectedIndexChanged += lstNutrinions_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NutritionID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "UserID";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Calorie";
            columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Measurement";
            columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Portion Type";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Category";
            columnHeader7.Width = 100;
            // 
            // gbxAddNutrition
            // 
            gbxAddNutrition.Controls.Add(label5);
            gbxAddNutrition.Controls.Add(txtMeasurement);
            gbxAddNutrition.Controls.Add(pbNutritionImage);
            gbxAddNutrition.Controls.Add(label4);
            gbxAddNutrition.Controls.Add(cbCategory);
            gbxAddNutrition.Controls.Add(label3);
            gbxAddNutrition.Controls.Add(cbPortionType);
            gbxAddNutrition.Controls.Add(label2);
            gbxAddNutrition.Controls.Add(txtCalorie);
            gbxAddNutrition.Controls.Add(btnDelete);
            gbxAddNutrition.Controls.Add(btnUpdate);
            gbxAddNutrition.Controls.Add(btnAdd);
            gbxAddNutrition.Controls.Add(label1);
            gbxAddNutrition.Controls.Add(txtNutritionName);
            gbxAddNutrition.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAddNutrition.Location = new Point(12, 12);
            gbxAddNutrition.Name = "gbxAddNutrition";
            gbxAddNutrition.Size = new Size(378, 464);
            gbxAddNutrition.TabIndex = 11;
            gbxAddNutrition.TabStop = false;
            gbxAddNutrition.Text = "Add Nutrition";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 244);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 15;
            label5.Text = "Measurement:";
            // 
            // txtMeasurement
            // 
            txtMeasurement.Location = new Point(181, 238);
            txtMeasurement.Name = "txtMeasurement";
            txtMeasurement.Size = new Size(170, 27);
            txtMeasurement.TabIndex = 14;
            // 
            // pbNutritionImage
            // 
            pbNutritionImage.BorderStyle = BorderStyle.FixedSingle;
            pbNutritionImage.Image = (Image)resources.GetObject("pbNutritionImage.Image");
            pbNutritionImage.Location = new Point(116, 26);
            pbNutritionImage.Name = "pbNutritionImage";
            pbNutritionImage.Size = new Size(134, 98);
            pbNutritionImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNutritionImage.TabIndex = 13;
            pbNutritionImage.TabStop = false;
            pbNutritionImage.Click += pbNutritionImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 337);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 12;
            label4.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(181, 329);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(170, 29);
            cbCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 289);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 10;
            label3.Text = "Portion Type:";
            // 
            // cbPortionType
            // 
            cbPortionType.FormattingEnabled = true;
            cbPortionType.Location = new Point(181, 281);
            cbPortionType.Name = "cbPortionType";
            cbPortionType.Size = new Size(170, 29);
            cbPortionType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 202);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 8;
            label2.Text = "Calorie:";
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(181, 196);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(170, 27);
            txtCalorie.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(25, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(148, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 45);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(266, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 161);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 1;
            label1.Text = "Nutrition Name:";
            // 
            // txtNutritionName
            // 
            txtNutritionName.Location = new Point(181, 155);
            txtNutritionName.Name = "txtNutritionName";
            txtNutritionName.Size = new Size(170, 27);
            txtNutritionName.TabIndex = 0;
            // 
            // AddNutritionScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 557);
            Controls.Add(grpMeals);
            Controls.Add(gbxAddNutrition);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNutritionScreen";
            Text = "AddNutritionScreen";
            Load += AddNutritionScreen_Load;
            grpMeals.ResumeLayout(false);
            gbxAddNutrition.ResumeLayout(false);
            gbxAddNutrition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMeals;
        private ListView lstNutrinions;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private GroupBox gbxAddNutrition;
        private Label label4;
        private ComboBox cbCategory;
        private Label label3;
        private ComboBox cbPortionType;
        private Label label2;
        private TextBox txtCalorie;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private TextBox txtNutritionName;
        private PictureBox pbNutritionImage;
        private Label label5;
        private TextBox txtMeasurement;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}