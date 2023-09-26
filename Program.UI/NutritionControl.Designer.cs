namespace Program.UI
{
    partial class NutritionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionControl));
            btnAdd = new Button();
            lblNutritionName = new Label();
            lblNutCalorie = new Label();
            label4 = new Label();
            lblNutMeasurement = new Label();
            lblNutMeasurementType = new Label();
            pbNutritionImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(118, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(48, 35);
            btnAdd.TabIndex = 19;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblNutritionName
            // 
            lblNutritionName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutritionName.Location = new Point(3, 90);
            lblNutritionName.Name = "lblNutritionName";
            lblNutritionName.Size = new Size(163, 16);
            lblNutritionName.TabIndex = 18;
            lblNutritionName.Text = "Nutrition Name";
            // 
            // lblNutCalorie
            // 
            lblNutCalorie.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutCalorie.Location = new Point(85, 137);
            lblNutCalorie.Name = "lblNutCalorie";
            lblNutCalorie.Size = new Size(43, 16);
            lblNutCalorie.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 137);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 16;
            label4.Text = "Calorie:";
            // 
            // lblNutMeasurement
            // 
            lblNutMeasurement.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutMeasurement.Location = new Point(85, 110);
            lblNutMeasurement.Name = "lblNutMeasurement";
            lblNutMeasurement.Size = new Size(43, 16);
            lblNutMeasurement.TabIndex = 15;
            // 
            // lblNutMeasurementType
            // 
            lblNutMeasurementType.AutoSize = true;
            lblNutMeasurementType.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNutMeasurementType.Location = new Point(3, 110);
            lblNutMeasurementType.Name = "lblNutMeasurementType";
            lblNutMeasurementType.Size = new Size(48, 16);
            lblNutMeasurementType.TabIndex = 14;
            lblNutMeasurementType.Text = "Gram:";
            // 
            // pbNutritionImage
            // 
            pbNutritionImage.Location = new Point(16, 7);
            pbNutritionImage.Name = "pbNutritionImage";
            pbNutritionImage.Size = new Size(131, 80);
            pbNutritionImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNutritionImage.TabIndex = 13;
            pbNutritionImage.TabStop = false;
            // 
            // NutritionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(lblNutritionName);
            Controls.Add(lblNutCalorie);
            Controls.Add(label4);
            Controls.Add(lblNutMeasurement);
            Controls.Add(lblNutMeasurementType);
            Controls.Add(pbNutritionImage);
            Name = "NutritionControl";
            Size = new Size(169, 161);
            ((System.ComponentModel.ISupportInitialize)pbNutritionImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnAdd;
        private Label lblNutritionName;
        private Label lblNutCalorie;
        private Label label4;
        private Label lblNutMeasurement;
        private Label lblNutMeasurementType;
        private PictureBox pbNutritionImage;
    }
}
