namespace Program.UI
{
    partial class HealthStatusScreen
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
            groupBox1 = new GroupBox();
            btnCalculate = new Button();
            label1 = new Label();
            lblCalorieNeed = new Label();
            label10 = new Label();
            rbActive = new RadioButton();
            rbModerate = new RadioButton();
            rbLight = new RadioButton();
            rbSedentary = new RadioButton();
            lblUserGender = new Label();
            label9 = new Label();
            lblUserWeight = new Label();
            label7 = new Label();
            lblUserHeight = new Label();
            label5 = new Label();
            lblUserAge = new Label();
            label2 = new Label();
            pbCalorieStatus = new ProgressBar();
            groupBox2 = new GroupBox();
            flpUsersMealsCalories = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblCalorieNeed);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rbActive);
            groupBox1.Controls.Add(rbModerate);
            groupBox1.Controls.Add(rbLight);
            groupBox1.Controls.Add(rbSedentary);
            groupBox1.Controls.Add(lblUserGender);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblUserWeight);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblUserHeight);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblUserAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(32, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 306);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Daily Calorie Consumption Calculator";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(370, 94);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(97, 48);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 19);
            label1.TabIndex = 23;
            label1.Text = "Daily Physical Activity";
            // 
            // lblCalorieNeed
            // 
            lblCalorieNeed.AutoSize = true;
            lblCalorieNeed.Location = new Point(295, 240);
            lblCalorieNeed.Name = "lblCalorieNeed";
            lblCalorieNeed.Size = new Size(65, 19);
            lblCalorieNeed.TabIndex = 22;
            lblCalorieNeed.Text = "Calorie";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 240);
            label10.Name = "label10";
            label10.Size = new Size(198, 19);
            label10.TabIndex = 21;
            label10.Text = "Your Daily Calorie Need:";
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Location = new Point(198, 175);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(76, 23);
            rbActive.TabIndex = 20;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbModerate
            // 
            rbModerate.AutoSize = true;
            rbModerate.Location = new Point(198, 134);
            rbModerate.Name = "rbModerate";
            rbModerate.Size = new Size(102, 23);
            rbModerate.TabIndex = 19;
            rbModerate.TabStop = true;
            rbModerate.Text = "Moderate";
            rbModerate.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            rbLight.AutoSize = true;
            rbLight.Location = new Point(198, 93);
            rbLight.Name = "rbLight";
            rbLight.Size = new Size(63, 23);
            rbLight.TabIndex = 18;
            rbLight.TabStop = true;
            rbLight.Text = "Light";
            rbLight.UseVisualStyleBackColor = true;
            // 
            // rbSedentary
            // 
            rbSedentary.AutoSize = true;
            rbSedentary.Location = new Point(198, 58);
            rbSedentary.Name = "rbSedentary";
            rbSedentary.Size = new Size(105, 23);
            rbSedentary.TabIndex = 17;
            rbSedentary.TabStop = true;
            rbSedentary.Text = "Sedentary";
            rbSedentary.UseVisualStyleBackColor = true;
            // 
            // lblUserGender
            // 
            lblUserGender.AutoSize = true;
            lblUserGender.Location = new Point(84, 164);
            lblUserGender.Name = "lblUserGender";
            lblUserGender.Size = new Size(68, 19);
            lblUserGender.TabIndex = 16;
            lblUserGender.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 164);
            label9.Name = "label9";
            label9.Size = new Size(72, 19);
            label9.TabIndex = 15;
            label9.Text = "Gender:";
            // 
            // lblUserWeight
            // 
            lblUserWeight.AutoSize = true;
            lblUserWeight.Location = new Point(84, 123);
            lblUserWeight.Name = "lblUserWeight";
            lblUserWeight.Size = new Size(62, 19);
            lblUserWeight.TabIndex = 14;
            lblUserWeight.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 123);
            label7.Name = "label7";
            label7.Size = new Size(66, 19);
            label7.TabIndex = 13;
            label7.Text = "Weight:";
            // 
            // lblUserHeight
            // 
            lblUserHeight.AutoSize = true;
            lblUserHeight.Location = new Point(84, 84);
            lblUserHeight.Name = "lblUserHeight";
            lblUserHeight.Size = new Size(59, 19);
            lblUserHeight.TabIndex = 12;
            lblUserHeight.Text = "Height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 84);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 11;
            label5.Text = "Height:";
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Location = new Point(84, 47);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(42, 19);
            lblUserAge.TabIndex = 10;
            lblUserAge.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 47);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 9;
            label2.Text = "Age:";
            // 
            // pbCalorieStatus
            // 
            pbCalorieStatus.Location = new Point(212, 422);
            pbCalorieStatus.Name = "pbCalorieStatus";
            pbCalorieStatus.Size = new Size(474, 48);
            pbCalorieStatus.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flpUsersMealsCalories);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(551, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 306);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Today's User's Meals Calories";
            // 
            // flpUsersMealsCalories
            // 
            flpUsersMealsCalories.Location = new Point(6, 25);
            flpUsersMealsCalories.Name = "flpUsersMealsCalories";
            flpUsersMealsCalories.Size = new Size(309, 275);
            flpUsersMealsCalories.TabIndex = 0;
            // 
            // HealthStatusScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 557);
            Controls.Add(groupBox2);
            Controls.Add(pbCalorieStatus);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HealthStatusScreen";
            Text = "HealthStatusScreen";
            Load += HealthStatusScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblUserGender;
        private Label label9;
        private Label lblUserWeight;
        private Label label7;
        private Label lblUserHeight;
        private Label label5;
        private Label lblUserAge;
        private Label label2;
        private RadioButton rbActive;
        private RadioButton rbModerate;
        private RadioButton rbLight;
        private RadioButton rbSedentary;
        private Label lblCalorieNeed;
        private Label label10;
        private Label label1;
        private Button btnCalculate;
        private ProgressBar pbCalorieStatus;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpUsersMealsCalories;
    }
}