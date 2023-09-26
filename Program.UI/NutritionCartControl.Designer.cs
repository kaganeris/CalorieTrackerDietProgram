namespace Program.UI
{
    partial class NutritionCartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionCartControl));
            btnPlus = new Button();
            lblCount = new Label();
            btnMinus = new Button();
            lblNutCalorie = new Label();
            label4 = new Label();
            lblNutMeasurement = new Label();
            lblNutMeasurementType = new Label();
            lblNutritionName = new Label();
            pbNutritionImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).BeginInit();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Image = (Image)resources.GetObject("btnPlus.Image");
            btnPlus.Location = new Point(207, 69);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(34, 30);
            btnPlus.TabIndex = 17;
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.Location = new Point(175, 76);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(16, 18);
            lblCount.TabIndex = 16;
            lblCount.Text = "1";
            // 
            // btnMinus
            // 
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Image = (Image)resources.GetObject("btnMinus.Image");
            btnMinus.Location = new Point(130, 71);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(27, 25);
            btnMinus.TabIndex = 15;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblNutCalorie
            // 
            lblNutCalorie.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutCalorie.Location = new Point(221, 47);
            lblNutCalorie.Name = "lblNutCalorie";
            lblNutCalorie.Size = new Size(50, 23);
            lblNutCalorie.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(130, 47);
            label4.Name = "label4";
            label4.Size = new Size(67, 18);
            label4.TabIndex = 13;
            label4.Text = "Calorie:";
            // 
            // lblNutMeasurement
            // 
            lblNutMeasurement.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutMeasurement.Location = new Point(221, 22);
            lblNutMeasurement.Name = "lblNutMeasurement";
            lblNutMeasurement.Size = new Size(50, 23);
            lblNutMeasurement.TabIndex = 12;
            // 
            // lblNutMeasurementType
            // 
            lblNutMeasurementType.AutoSize = true;
            lblNutMeasurementType.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutMeasurementType.Location = new Point(130, 22);
            lblNutMeasurementType.Name = "lblNutMeasurementType";
            lblNutMeasurementType.Size = new Size(54, 18);
            lblNutMeasurementType.TabIndex = 11;
            lblNutMeasurementType.Text = "Gram:";
            // 
            // lblNutritionName
            // 
            lblNutritionName.AutoSize = true;
            lblNutritionName.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutritionName.Location = new Point(149, 2);
            lblNutritionName.Name = "lblNutritionName";
            lblNutritionName.Size = new Size(117, 18);
            lblNutritionName.TabIndex = 10;
            lblNutritionName.Text = "Nutrition Name";
            // 
            // pbNutritionImage
            // 
            pbNutritionImage.Location = new Point(11, 2);
            pbNutritionImage.Name = "pbNutritionImage";
            pbNutritionImage.Size = new Size(103, 94);
            pbNutritionImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNutritionImage.TabIndex = 9;
            pbNutritionImage.TabStop = false;
            // 
            // NutritionCartControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPlus);
            Controls.Add(lblCount);
            Controls.Add(btnMinus);
            Controls.Add(lblNutCalorie);
            Controls.Add(label4);
            Controls.Add(lblNutMeasurement);
            Controls.Add(lblNutMeasurementType);
            Controls.Add(lblNutritionName);
            Controls.Add(pbNutritionImage);
            Name = "NutritionCartControl";
            Size = new Size(271, 100);
            Load += NutritionCartControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Label lblNutCalorie;
        private Label label4;
        private Label lblNutMeasurement;
        private Label lblNutMeasurementType;
        private Label lblNutritionName;
        private PictureBox pbNutritionImage;
        public Label lblCount;
    }
}
