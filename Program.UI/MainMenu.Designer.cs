namespace Program.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel2 = new Panel();
            label2 = new Label();
            lblTime = new Label();
            btnUserInfo = new Button();
            btnApplicationExit = new Button();
            panel1 = new Panel();
            btnAnalize = new Button();
            pbLogo = new PictureBox();
            btnAddNutrition = new Button();
            btnHealthStatus = new Button();
            btnAddMeal = new Button();
            btnHistory = new Button();
            btnHome = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(btnUserInfo);
            panel2.Controls.Add(btnApplicationExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 72);
            panel2.TabIndex = 3;
            panel2.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 21);
            label2.Name = "label2";
            label2.Size = new Size(232, 21);
            label2.TabIndex = 6;
            label2.Text = "Calorie Tracker Diet Program";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(509, 21);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(58, 28);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time";
            // 
            // btnUserInfo
            // 
            btnUserInfo.FlatAppearance.BorderSize = 0;
            btnUserInfo.FlatStyle = FlatStyle.Flat;
            btnUserInfo.ForeColor = SystemColors.ControlText;
            btnUserInfo.Image = (Image)resources.GetObject("btnUserInfo.Image");
            btnUserInfo.Location = new Point(754, 3);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Size = new Size(63, 60);
            btnUserInfo.TabIndex = 4;
            btnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserInfo.UseVisualStyleBackColor = true;
            btnUserInfo.Click += btnUserInfo_Click;
            // 
            // btnApplicationExit
            // 
            btnApplicationExit.FlatAppearance.BorderSize = 0;
            btnApplicationExit.FlatStyle = FlatStyle.Flat;
            btnApplicationExit.ForeColor = SystemColors.ControlText;
            btnApplicationExit.Image = (Image)resources.GetObject("btnApplicationExit.Image");
            btnApplicationExit.Location = new Point(823, 12);
            btnApplicationExit.Name = "btnApplicationExit";
            btnApplicationExit.Size = new Size(48, 42);
            btnApplicationExit.TabIndex = 4;
            btnApplicationExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplicationExit.UseVisualStyleBackColor = true;
            btnApplicationExit.Click += btnApplicationExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAnalize);
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(btnAddNutrition);
            panel1.Controls.Add(btnHealthStatus);
            panel1.Controls.Add(btnAddMeal);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 635);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnAnalize
            // 
            btnAnalize.FlatAppearance.BorderSize = 0;
            btnAnalize.FlatStyle = FlatStyle.Flat;
            btnAnalize.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnalize.ForeColor = SystemColors.ControlText;
            btnAnalize.Image = (Image)resources.GetObject("btnAnalize.Image");
            btnAnalize.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalize.Location = new Point(3, 405);
            btnAnalize.Name = "btnAnalize";
            btnAnalize.Size = new Size(192, 62);
            btnAnalize.TabIndex = 4;
            btnAnalize.Text = "       ANALYSIS";
            btnAnalize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalize.UseVisualStyleBackColor = true;
            btnAnalize.Click += btnAnalize_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(21, 24);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(157, 113);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // btnAddNutrition
            // 
            btnAddNutrition.FlatAppearance.BorderSize = 0;
            btnAddNutrition.FlatStyle = FlatStyle.Flat;
            btnAddNutrition.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNutrition.ForeColor = SystemColors.ControlText;
            btnAddNutrition.Image = (Image)resources.GetObject("btnAddNutrition.Image");
            btnAddNutrition.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNutrition.Location = new Point(7, 551);
            btnAddNutrition.Name = "btnAddNutrition";
            btnAddNutrition.Size = new Size(188, 73);
            btnAddNutrition.TabIndex = 3;
            btnAddNutrition.Text = "       ADD \r\n     NUTRITION";
            btnAddNutrition.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNutrition.UseVisualStyleBackColor = true;
            btnAddNutrition.Click += btnAddNutrition_Click;
            // 
            // btnHealthStatus
            // 
            btnHealthStatus.FlatAppearance.BorderSize = 0;
            btnHealthStatus.FlatStyle = FlatStyle.Flat;
            btnHealthStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHealthStatus.ForeColor = SystemColors.ControlText;
            btnHealthStatus.Image = (Image)resources.GetObject("btnHealthStatus.Image");
            btnHealthStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnHealthStatus.Location = new Point(0, 240);
            btnHealthStatus.Name = "btnHealthStatus";
            btnHealthStatus.Size = new Size(200, 72);
            btnHealthStatus.TabIndex = 3;
            btnHealthStatus.Text = "     HEALTH \r\n   STATUS";
            btnHealthStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHealthStatus.UseVisualStyleBackColor = true;
            btnHealthStatus.Click += btnHealthStatus_Click;
            // 
            // btnAddMeal
            // 
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMeal.ForeColor = SystemColors.ControlText;
            btnAddMeal.Image = (Image)resources.GetObject("btnAddMeal.Image");
            btnAddMeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMeal.Location = new Point(7, 483);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(188, 62);
            btnAddMeal.TabIndex = 3;
            btnAddMeal.Text = "       ADD MEAL";
            btnAddMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = SystemColors.ControlText;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(3, 318);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(191, 66);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "       HISTORY";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.Black;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 170);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(197, 76);
            btnHome.TabIndex = 2;
            btnHome.Text = "       HOME";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 635);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTime;
        private Button btnUserInfo;
        private Button btnApplicationExit;
        private Panel panel1;
        private PictureBox pbLogo;
        private Button btnAddNutrition;
        private Button btnAddMeal;
        private Button btnHistory;
        private Button btnHealthStatus;
        private Button btnHome;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button btnAnalize;
    }
}