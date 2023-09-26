namespace Program.UI
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            panel2 = new Panel();
            pbPhoto = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            chbShowPassword = new CheckBox();
            txtLastName = new TextBox();
            label18 = new Label();
            pictureBox4 = new PictureBox();
            txtFirstName = new TextBox();
            label19 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            txtPassword = new TextBox();
            label5 = new Label();
            ptbPasswordInfo = new PictureBox();
            txtConfirmPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlRegister = new Panel();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            cmbSecurityQuestion = new ComboBox();
            pictureBox6 = new PictureBox();
            dtpBirthDate = new DateTimePicker();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox7 = new PictureBox();
            linkAlreadyAcoount = new LinkLabel();
            btnRegister = new Button();
            txtWeight = new TextBox();
            txtAnswer = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            txtHeight = new TextBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            btnClose = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbPhoto);
            panel2.Controls.Add(pictureBox19);
            panel2.Controls.Add(pictureBox20);
            panel2.Controls.Add(chbShowPassword);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ptbPasswordInfo);
            panel2.Controls.Add(txtConfirmPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(89, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 718);
            panel2.TabIndex = 19;
            // 
            // pbPhoto
            // 
            pbPhoto.Image = (Image)resources.GetObject("pbPhoto.Image");
            pbPhoto.Location = new Point(121, 15);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(141, 166);
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.TabIndex = 11;
            pbPhoto.TabStop = false;
            pbPhoto.Click += pbPhoto_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = (Image)resources.GetObject("pictureBox19.Image");
            pictureBox19.Location = new Point(52, 347);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(32, 35);
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.TabIndex = 5;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.Image = (Image)resources.GetObject("pictureBox20.Image");
            pictureBox20.Location = new Point(52, 261);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(32, 35);
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.TabIndex = 5;
            pictureBox20.TabStop = false;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chbShowPassword.Location = new Point(141, 658);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(147, 25);
            chbShowPassword.TabIndex = 5;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(90, 347);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Type your last name";
            txtLastName.Size = new Size(240, 35);
            txtLastName.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(146, 312);
            label18.Name = "label18";
            label18.Size = new Size(91, 21);
            label18.TabIndex = 3;
            label18.Text = "Last name";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(92, 653);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(90, 261);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Type your name";
            txtFirstName.Size = new Size(240, 35);
            txtFirstName.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(147, 221);
            label19.Name = "label19";
            label19.Size = new Size(89, 21);
            label19.TabIndex = 3;
            label19.Text = "First name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(162, 398);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 3;
            label3.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 438);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Type your e-mail";
            txtEmail.Size = new Size(240, 35);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(149, 489);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(51, 606);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 524);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Type your password";
            txtPassword.Size = new Size(240, 35);
            txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(117, 571);
            label5.Name = "label5";
            label5.Size = new Size(147, 21);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password";
            // 
            // ptbPasswordInfo
            // 
            ptbPasswordInfo.Image = (Image)resources.GetObject("ptbPasswordInfo.Image");
            ptbPasswordInfo.Location = new Point(335, 524);
            ptbPasswordInfo.Name = "ptbPasswordInfo";
            ptbPasswordInfo.Size = new Size(32, 35);
            ptbPasswordInfo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPasswordInfo.TabIndex = 5;
            ptbPasswordInfo.TabStop = false;
            ptbPasswordInfo.Click += ptbPasswordInfo_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(89, 606);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(240, 35);
            txtConfirmPassword.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(51, 524);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 438);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.Controls.Add(rbFemale);
            pnlRegister.Controls.Add(rbMale);
            pnlRegister.Controls.Add(cmbSecurityQuestion);
            pnlRegister.Controls.Add(pictureBox6);
            pnlRegister.Controls.Add(dtpBirthDate);
            pnlRegister.Controls.Add(pictureBox8);
            pnlRegister.Controls.Add(pictureBox9);
            pnlRegister.Controls.Add(pictureBox10);
            pnlRegister.Controls.Add(pictureBox7);
            pnlRegister.Controls.Add(linkAlreadyAcoount);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(txtWeight);
            pnlRegister.Controls.Add(txtAnswer);
            pnlRegister.Controls.Add(label7);
            pnlRegister.Controls.Add(label8);
            pnlRegister.Controls.Add(label10);
            pnlRegister.Controls.Add(label9);
            pnlRegister.Controls.Add(label1);
            pnlRegister.Controls.Add(txtHeight);
            pnlRegister.Controls.Add(label6);
            pnlRegister.Location = new Point(722, 104);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(382, 718);
            pnlRegister.TabIndex = 20;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbFemale.Location = new Point(190, 254);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(85, 25);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbMale.Location = new Point(108, 254);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(67, 25);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // cmbSecurityQuestion
            // 
            cmbSecurityQuestion.FormattingEnabled = true;
            cmbSecurityQuestion.Items.AddRange(new object[] { "In what city were you born?", "What is the name of your favorite pet?", "What is your mother's maiden name?", "What high school did you attend?", "What was the make of your first car?", "What was your favorite food as a child?", "Where did you meet your spouse?", "What year was your father (or mother) born?" });
            cmbSecurityQuestion.Location = new Point(90, 88);
            cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            cmbSecurityQuestion.Size = new Size(240, 23);
            cmbSecurityQuestion.TabIndex = 6;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(52, 326);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Location = new Point(90, 334);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(240, 27);
            dtpBirthDate.TabIndex = 10;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(52, 494);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(32, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 5;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(52, 81);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 35);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(52, 163);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 35);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 5;
            pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(52, 412);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // linkAlreadyAcoount
            // 
            linkAlreadyAcoount.AutoSize = true;
            linkAlreadyAcoount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkAlreadyAcoount.LinkColor = Color.FromArgb(128, 255, 255);
            linkAlreadyAcoount.Location = new Point(77, 653);
            linkAlreadyAcoount.Name = "linkAlreadyAcoount";
            linkAlreadyAcoount.Size = new Size(228, 21);
            linkAlreadyAcoount.TabIndex = 14;
            linkAlreadyAcoount.TabStop = true;
            linkAlreadyAcoount.Text = "Already have an Account ?";
            linkAlreadyAcoount.LinkClicked += linkAlreadyAcoount_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderColor = Color.White;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(98, 571);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(187, 41);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(90, 494);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "kg";
            txtWeight.Size = new Size(240, 35);
            txtWeight.TabIndex = 12;
            txtWeight.KeyPress += txtHeight_KeyPress;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(90, 163);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.PlaceholderText = "Type your answer";
            txtAnswer.Size = new Size(240, 35);
            txtAnswer.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(158, 459);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 3;
            label7.Text = "Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(119, 46);
            label8.Name = "label8";
            label8.Size = new Size(145, 21);
            label8.TabIndex = 3;
            label8.Text = "Security Question";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(156, 215);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 3;
            label10.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(150, 296);
            label9.Name = "label9";
            label9.Size = new Size(83, 21);
            label9.TabIndex = 3;
            label9.Text = "Birthdate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(157, 127);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 3;
            label1.Text = "Answer";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(90, 412);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.PlaceholderText = "cm";
            txtHeight.Size = new Size(240, 35);
            txtHeight.TabIndex = 11;
            txtHeight.KeyPress += txtHeight_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(160, 377);
            label6.Name = "label6";
            label6.Size = new Size(62, 21);
            label6.TabIndex = 3;
            label6.Text = "Height";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Cross;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1182, 815);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 41);
            panel1.TabIndex = 17;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 1;
            label2.Text = "Diet Tracking Program";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Orange;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Orange;
            btnClose.Location = new Point(1136, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 41);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 856);
            Controls.Add(panel2);
            Controls.Add(pnlRegister);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            Load += RegisterScreen_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pbPhoto;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private CheckBox chbShowPassword;
        private TextBox txtLastName;
        private Label label18;
        private PictureBox pictureBox4;
        private TextBox txtFirstName;
        private Label label19;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox pictureBox5;
        private TextBox txtPassword;
        private Label label5;
        private PictureBox ptbPasswordInfo;
        private TextBox txtConfirmPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlRegister;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private ComboBox cmbSecurityQuestion;
        private PictureBox pictureBox6;
        private DateTimePicker dtpBirthDate;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox7;
        private LinkLabel linkAlreadyAcoount;
        private Button btnRegister;
        private TextBox txtWeight;
        private TextBox txtAnswer;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label1;
        private TextBox txtHeight;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private Button btnClose;
    }
}