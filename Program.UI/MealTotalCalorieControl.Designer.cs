namespace Program.UI
{
    partial class MealTotalCalorieControl
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
            lblMealCalorie = new Label();
            lblMealName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMealCalorie
            // 
            lblMealCalorie.AutoSize = true;
            lblMealCalorie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealCalorie.Location = new Point(111, 12);
            lblMealCalorie.Name = "lblMealCalorie";
            lblMealCalorie.Size = new Size(65, 19);
            lblMealCalorie.TabIndex = 29;
            lblMealCalorie.Text = "Calorie";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(8, 12);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(97, 19);
            lblMealName.TabIndex = 28;
            lblMealName.Text = "MealName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(182, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 30;
            label1.Text = "cal";
            // 
            // MealTotalCalorieControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lblMealCalorie);
            Controls.Add(lblMealName);
            Name = "MealTotalCalorieControl";
            Size = new Size(235, 43);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMealCalorie;
        private Label lblMealName;
        private Label label1;
    }
}
