namespace Program.UI
{
    partial class PasswordRenewScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRenewScreen));
            pnlLogin = new Panel();
            ptbPasswordInfo = new PictureBox();
            chbShowPassword = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            cmbSecurityQuestion = new ComboBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            txtNewPassword = new TextBox();
            txtAnswer = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnUpdatePassword = new Button();
            pictureBox1 = new PictureBox();
            btnCheckInfos = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            btnClose = new Button();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.ControlLightLight;
            pnlLogin.Controls.Add(ptbPasswordInfo);
            pnlLogin.Controls.Add(chbShowPassword);
            pnlLogin.Controls.Add(pictureBox4);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(cmbSecurityQuestion);
            pnlLogin.Controls.Add(pictureBox9);
            pnlLogin.Controls.Add(pictureBox10);
            pnlLogin.Controls.Add(txtNewPassword);
            pnlLogin.Controls.Add(txtAnswer);
            pnlLogin.Controls.Add(label8);
            pnlLogin.Controls.Add(label5);
            pnlLogin.Controls.Add(label4);
            pnlLogin.Controls.Add(btnUpdatePassword);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(btnCheckInfos);
            pnlLogin.Controls.Add(txtEmail);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Location = new Point(272, 115);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(382, 677);
            pnlLogin.TabIndex = 9;
            // 
            // ptbPasswordInfo
            // 
            ptbPasswordInfo.Image = (Image)resources.GetObject("ptbPasswordInfo.Image");
            ptbPasswordInfo.Location = new Point(336, 468);
            ptbPasswordInfo.Name = "ptbPasswordInfo";
            ptbPasswordInfo.Size = new Size(32, 35);
            ptbPasswordInfo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPasswordInfo.TabIndex = 19;
            ptbPasswordInfo.TabStop = false;
            ptbPasswordInfo.Click += ptbPasswordInfo_Click;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbShowPassword.Location = new Point(142, 526);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(147, 25);
            chbShowPassword.TabIndex = 5;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.Click += chbShowPassword_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(93, 521);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 468);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // cmbSecurityQuestion
            // 
            cmbSecurityQuestion.FormattingEnabled = true;
            cmbSecurityQuestion.Items.AddRange(new object[] { "In what city were you born?", "What is the name of your favorite pet?", "What is your mother's maiden name?", "What high school did you attend?", "What was the make of your first car?", "What was your favorite food as a child?", "Where did you meet your spouse?", "What year was your father (or mother) born?" });
            cmbSecurityQuestion.Location = new Point(90, 222);
            cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            cmbSecurityQuestion.Size = new Size(240, 23);
            cmbSecurityQuestion.TabIndex = 1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(52, 215);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 35);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(52, 297);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 35);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(90, 468);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Type your new password";
            txtNewPassword.Size = new Size(240, 35);
            txtNewPassword.TabIndex = 4;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(90, 297);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Type your answer";
            txtAnswer.Size = new Size(240, 35);
            txtAnswer.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(119, 180);
            label8.Name = "label8";
            label8.Size = new Size(145, 21);
            label8.TabIndex = 11;
            label8.Text = "Security Question";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(130, 422);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 12;
            label5.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(157, 261);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 12;
            label4.Text = "Answer";
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.Transparent;
            btnUpdatePassword.FlatAppearance.BorderColor = Color.White;
            btnUpdatePassword.FlatAppearance.MouseOverBackColor = Color.Red;
            btnUpdatePassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdatePassword.ForeColor = Color.Black;
            btnUpdatePassword.Location = new Point(98, 586);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(187, 41);
            btnUpdatePassword.TabIndex = 6;
            btnUpdatePassword.Text = "Update My Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnCheckInfos
            // 
            btnCheckInfos.BackColor = Color.Transparent;
            btnCheckInfos.FlatAppearance.BorderColor = Color.White;
            btnCheckInfos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCheckInfos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckInfos.ForeColor = Color.Black;
            btnCheckInfos.Location = new Point(98, 359);
            btnCheckInfos.Name = "btnCheckInfos";
            btnCheckInfos.Size = new Size(187, 41);
            btnCheckInfos.TabIndex = 3;
            btnCheckInfos.Text = "Check Information";
            btnCheckInfos.UseVisualStyleBackColor = false;
            btnCheckInfos.Click += btnCheckInfos_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 132);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 35);
            txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(163, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 3;
            label3.Text = "E-Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 32);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 2;
            label1.Text = "Renew Password";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Cross;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(684, 866);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 41);
            panel1.TabIndex = 10;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(234, 23);
            label2.TabIndex = 1;
            label2.Text = "Calorie Tracker Diet Program";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(638, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 41);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // PasswordRenewScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 907);
            Controls.Add(pnlLogin);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordRenewScreen";
            Text = "PasswordRenewScreen";
            Load += PasswordRenewScreen_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox ptbPasswordInfo;
        private CheckBox chbShowPassword;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private ComboBox cmbSecurityQuestion;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private TextBox txtNewPassword;
        private TextBox txtAnswer;
        private Label label8;
        private Label label5;
        private Label label4;
        private Button btnUpdatePassword;
        private PictureBox pictureBox1;
        private Button btnCheckInfos;
        private TextBox txtEmail;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Button btnClose;
    }
}