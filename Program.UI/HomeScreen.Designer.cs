namespace Program.UI
{
    partial class HomeScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            panel1 = new Panel();
            btnOthers = new Button();
            btnSalad = new Button();
            btnDairy = new Button();
            btnFishAndSeadfood = new Button();
            btnFastFood = new Button();
            btnMeatOrPoultry = new Button();
            btnGrainBeanNuts = new Button();
            btnDessert = new Button();
            btnSnack = new Button();
            btnAlcohol = new Button();
            btnSoftDrink = new Button();
            btnFruit = new Button();
            btnVegetable = new Button();
            btnSaveMeal = new Button();
            label2 = new Label();
            cmbMeals = new ComboBox();
            lblTotalCalorie = new Label();
            label1 = new Label();
            flpNutritionCart = new FlowLayoutPanel();
            flpNutritions = new FlowLayoutPanel();
            toolTip1 = new ToolTip(components);
            btnPreviousPage = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            txtSearchNtr = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnOthers);
            panel1.Controls.Add(btnSalad);
            panel1.Controls.Add(btnDairy);
            panel1.Controls.Add(btnFishAndSeadfood);
            panel1.Controls.Add(btnFastFood);
            panel1.Controls.Add(btnMeatOrPoultry);
            panel1.Controls.Add(btnGrainBeanNuts);
            panel1.Controls.Add(btnDessert);
            panel1.Controls.Add(btnSnack);
            panel1.Controls.Add(btnAlcohol);
            panel1.Controls.Add(btnSoftDrink);
            panel1.Controls.Add(btnFruit);
            panel1.Controls.Add(btnVegetable);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 53);
            panel1.TabIndex = 15;
            // 
            // btnOthers
            // 
            btnOthers.FlatAppearance.BorderSize = 0;
            btnOthers.FlatStyle = FlatStyle.Flat;
            btnOthers.Image = (Image)resources.GetObject("btnOthers.Image");
            btnOthers.Location = new Point(810, 1);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new Size(58, 47);
            btnOthers.TabIndex = 12;
            toolTip1.SetToolTip(btnOthers, "Others");
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // btnSalad
            // 
            btnSalad.FlatAppearance.BorderSize = 0;
            btnSalad.FlatStyle = FlatStyle.Flat;
            btnSalad.Image = (Image)resources.GetObject("btnSalad.Image");
            btnSalad.Location = new Point(390, 3);
            btnSalad.Name = "btnSalad";
            btnSalad.Size = new Size(58, 43);
            btnSalad.TabIndex = 11;
            toolTip1.SetToolTip(btnSalad, "Salads");
            btnSalad.UseVisualStyleBackColor = true;
            btnSalad.Click += btnSalad_Click;
            // 
            // btnDairy
            // 
            btnDairy.FlatAppearance.BorderSize = 0;
            btnDairy.FlatStyle = FlatStyle.Flat;
            btnDairy.Image = (Image)resources.GetObject("btnDairy.Image");
            btnDairy.Location = new Point(460, 3);
            btnDairy.Name = "btnDairy";
            btnDairy.Size = new Size(58, 43);
            btnDairy.TabIndex = 10;
            toolTip1.SetToolTip(btnDairy, "Dairies");
            btnDairy.UseVisualStyleBackColor = true;
            btnDairy.Click += btnDairy_Click;
            // 
            // btnFishAndSeadfood
            // 
            btnFishAndSeadfood.FlatAppearance.BorderSize = 0;
            btnFishAndSeadfood.FlatStyle = FlatStyle.Flat;
            btnFishAndSeadfood.Image = (Image)resources.GetObject("btnFishAndSeadfood.Image");
            btnFishAndSeadfood.Location = new Point(530, 3);
            btnFishAndSeadfood.Name = "btnFishAndSeadfood";
            btnFishAndSeadfood.Size = new Size(58, 43);
            btnFishAndSeadfood.TabIndex = 9;
            toolTip1.SetToolTip(btnFishAndSeadfood, "SeaFoods");
            btnFishAndSeadfood.UseVisualStyleBackColor = true;
            btnFishAndSeadfood.Click += btnFishAndSeadfood_Click;
            // 
            // btnFastFood
            // 
            btnFastFood.FlatAppearance.BorderSize = 0;
            btnFastFood.FlatStyle = FlatStyle.Flat;
            btnFastFood.Image = (Image)resources.GetObject("btnFastFood.Image");
            btnFastFood.Location = new Point(600, 3);
            btnFastFood.Name = "btnFastFood";
            btnFastFood.Size = new Size(58, 43);
            btnFastFood.TabIndex = 8;
            toolTip1.SetToolTip(btnFastFood, "Fast Foods");
            btnFastFood.UseVisualStyleBackColor = true;
            btnFastFood.Click += btnFastFood_Click;
            // 
            // btnMeatOrPoultry
            // 
            btnMeatOrPoultry.FlatAppearance.BorderSize = 0;
            btnMeatOrPoultry.FlatStyle = FlatStyle.Flat;
            btnMeatOrPoultry.Image = (Image)resources.GetObject("btnMeatOrPoultry.Image");
            btnMeatOrPoultry.Location = new Point(670, 3);
            btnMeatOrPoultry.Name = "btnMeatOrPoultry";
            btnMeatOrPoultry.Size = new Size(58, 47);
            btnMeatOrPoultry.TabIndex = 7;
            toolTip1.SetToolTip(btnMeatOrPoultry, "Meats or Poultrys");
            btnMeatOrPoultry.UseVisualStyleBackColor = true;
            btnMeatOrPoultry.Click += btnMeatOrPoultry_Click;
            // 
            // btnGrainBeanNuts
            // 
            btnGrainBeanNuts.FlatAppearance.BorderSize = 0;
            btnGrainBeanNuts.FlatStyle = FlatStyle.Flat;
            btnGrainBeanNuts.Image = (Image)resources.GetObject("btnGrainBeanNuts.Image");
            btnGrainBeanNuts.Location = new Point(740, 3);
            btnGrainBeanNuts.Name = "btnGrainBeanNuts";
            btnGrainBeanNuts.Size = new Size(58, 47);
            btnGrainBeanNuts.TabIndex = 6;
            toolTip1.SetToolTip(btnGrainBeanNuts, "Grain, Bean and Nuts");
            btnGrainBeanNuts.UseVisualStyleBackColor = true;
            btnGrainBeanNuts.Click += btnGrainBeanNuts_Click;
            // 
            // btnDessert
            // 
            btnDessert.FlatAppearance.BorderSize = 0;
            btnDessert.FlatStyle = FlatStyle.Flat;
            btnDessert.Image = (Image)resources.GetObject("btnDessert.Image");
            btnDessert.Location = new Point(320, 1);
            btnDessert.Name = "btnDessert";
            btnDessert.Size = new Size(58, 47);
            btnDessert.TabIndex = 5;
            toolTip1.SetToolTip(btnDessert, "Desserts");
            btnDessert.UseVisualStyleBackColor = true;
            btnDessert.Click += btnDessert_Click;
            // 
            // btnSnack
            // 
            btnSnack.FlatAppearance.BorderSize = 0;
            btnSnack.FlatStyle = FlatStyle.Flat;
            btnSnack.Image = (Image)resources.GetObject("btnSnack.Image");
            btnSnack.Location = new Point(250, 8);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(58, 38);
            btnSnack.TabIndex = 4;
            toolTip1.SetToolTip(btnSnack, "Snacks");
            btnSnack.UseVisualStyleBackColor = true;
            btnSnack.Click += btnSnack_Click;
            // 
            // btnAlcohol
            // 
            btnAlcohol.FlatAppearance.BorderSize = 0;
            btnAlcohol.FlatStyle = FlatStyle.Flat;
            btnAlcohol.Image = (Image)resources.GetObject("btnAlcohol.Image");
            btnAlcohol.Location = new Point(186, 3);
            btnAlcohol.Name = "btnAlcohol";
            btnAlcohol.Size = new Size(52, 47);
            btnAlcohol.TabIndex = 3;
            toolTip1.SetToolTip(btnAlcohol, "Alcohols");
            btnAlcohol.UseVisualStyleBackColor = true;
            btnAlcohol.Click += btnAlcohol_Click;
            // 
            // btnSoftDrink
            // 
            btnSoftDrink.FlatAppearance.BorderSize = 0;
            btnSoftDrink.FlatStyle = FlatStyle.Flat;
            btnSoftDrink.Image = (Image)resources.GetObject("btnSoftDrink.Image");
            btnSoftDrink.Location = new Point(125, 0);
            btnSoftDrink.Name = "btnSoftDrink";
            btnSoftDrink.Size = new Size(49, 46);
            btnSoftDrink.TabIndex = 2;
            toolTip1.SetToolTip(btnSoftDrink, "Soft Drinks");
            btnSoftDrink.UseVisualStyleBackColor = true;
            btnSoftDrink.Click += btnSoftDrink_Click;
            // 
            // btnFruit
            // 
            btnFruit.FlatAppearance.BorderSize = 0;
            btnFruit.FlatStyle = FlatStyle.Flat;
            btnFruit.Image = (Image)resources.GetObject("btnFruit.Image");
            btnFruit.Location = new Point(68, 3);
            btnFruit.Name = "btnFruit";
            btnFruit.Size = new Size(45, 43);
            btnFruit.TabIndex = 1;
            toolTip1.SetToolTip(btnFruit, "Fruits");
            btnFruit.UseVisualStyleBackColor = true;
            btnFruit.Click += btnFruit_Click;
            // 
            // btnVegetable
            // 
            btnVegetable.FlatAppearance.BorderSize = 0;
            btnVegetable.FlatStyle = FlatStyle.Flat;
            btnVegetable.Image = (Image)resources.GetObject("btnVegetable.Image");
            btnVegetable.Location = new Point(12, 3);
            btnVegetable.Name = "btnVegetable";
            btnVegetable.Size = new Size(44, 43);
            btnVegetable.TabIndex = 0;
            toolTip1.SetToolTip(btnVegetable, "Vegetables");
            btnVegetable.UseVisualStyleBackColor = true;
            btnVegetable.Click += btnVegetable_Click;
            // 
            // btnSaveMeal
            // 
            btnSaveMeal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveMeal.Location = new Point(675, 508);
            btnSaveMeal.Name = "btnSaveMeal";
            btnSaveMeal.Size = new Size(121, 43);
            btnSaveMeal.TabIndex = 14;
            btnSaveMeal.Text = "Save Meal";
            btnSaveMeal.UseVisualStyleBackColor = true;
            btnSaveMeal.Click += btnSaveMeal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(588, 475);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 13;
            label2.Text = "Meal:";
            // 
            // cmbMeals
            // 
            cmbMeals.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMeals.FormattingEnabled = true;
            cmbMeals.Location = new Point(675, 472);
            cmbMeals.Name = "cmbMeals";
            cmbMeals.Size = new Size(121, 27);
            cmbMeals.TabIndex = 12;
            // 
            // lblTotalCalorie
            // 
            lblTotalCalorie.AutoSize = true;
            lblTotalCalorie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCalorie.Location = new Point(704, 446);
            lblTotalCalorie.Name = "lblTotalCalorie";
            lblTotalCalorie.Size = new Size(0, 19);
            lblTotalCalorie.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(588, 446);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 10;
            label1.Text = "Total Calorie:";
            // 
            // flpNutritionCart
            // 
            flpNutritionCart.AutoScroll = true;
            flpNutritionCart.BackColor = Color.Transparent;
            flpNutritionCart.BorderStyle = BorderStyle.FixedSingle;
            flpNutritionCart.Location = new Point(570, 66);
            flpNutritionCart.Name = "flpNutritionCart";
            flpNutritionCart.Size = new Size(302, 361);
            flpNutritionCart.TabIndex = 9;
            flpNutritionCart.ControlAdded += flpNutritionCart_ControlAdded;
            // 
            // flpNutritions
            // 
            flpNutritions.AutoScroll = true;
            flpNutritions.BackColor = Color.Transparent;
            flpNutritions.BorderStyle = BorderStyle.FixedSingle;
            flpNutritions.Location = new Point(12, 91);
            flpNutritions.Name = "flpNutritions";
            flpNutritions.Size = new Size(552, 430);
            flpNutritions.TabIndex = 8;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviousPage.Location = new Point(30, 528);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(103, 23);
            btnPreviousPage.TabIndex = 16;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPageNumber.Location = new Point(260, 533);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(40, 16);
            lblPageNumber.TabIndex = 17;
            lblPageNumber.Text = "Page";
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextPage.Location = new Point(463, 529);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(101, 23);
            btnNextPage.TabIndex = 18;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // txtSearchNtr
            // 
            txtSearchNtr.Location = new Point(390, 59);
            txtSearchNtr.Name = "txtSearchNtr";
            txtSearchNtr.PlaceholderText = "Search";
            txtSearchNtr.Size = new Size(170, 23);
            txtSearchNtr.TabIndex = 19;
            txtSearchNtr.TextChanged += txtSearchNtr_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(363, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 21;
            label3.Text = "Nutritions";
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 557);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtSearchNtr);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Controls.Add(btnPreviousPage);
            Controls.Add(panel1);
            Controls.Add(btnSaveMeal);
            Controls.Add(label2);
            Controls.Add(cmbMeals);
            Controls.Add(lblTotalCalorie);
            Controls.Add(label1);
            Controls.Add(flpNutritionCart);
            Controls.Add(flpNutritions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSalad;
        private Button btnDairy;
        private Button btnFishAndSeadfood;
        private Button btnFastFood;
        private Button btnMeatOrPoultry;
        private Button btnGrainBeanNuts;
        private Button btnDessert;
        private Button btnSnack;
        private Button btnAlcohol;
        private Button btnSoftDrink;
        private Button btnFruit;
        private Button btnVegetable;
        private Button btnSaveMeal;
        private Label label2;
        private ComboBox cmbMeals;
        private Label lblTotalCalorie;
        private Label label1;
        public FlowLayoutPanel flpNutritionCart;
        private FlowLayoutPanel flpNutritions;
        private ToolTip toolTip1;
        private Button btnPreviousPage;
        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnOthers;
        private TextBox txtSearchNtr;
        private PictureBox pictureBox1;
        private Label label3;
    }
}