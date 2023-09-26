namespace Program.UI
{
    partial class AdminPanel
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
            lvUsers = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            grpAdminPanel = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            grpAdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lvUsers
            // 
            lvUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            lvUsers.Location = new Point(6, 22);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(257, 273);
            lvUsers.TabIndex = 0;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.Click += lvUsers_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "UsersID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Password";
            columnHeader3.Width = 90;
            // 
            // grpAdminPanel
            // 
            grpAdminPanel.Controls.Add(lvUsers);
            grpAdminPanel.Location = new Point(12, 12);
            grpAdminPanel.Name = "grpAdminPanel";
            grpAdminPanel.Size = new Size(269, 301);
            grpAdminPanel.TabIndex = 1;
            grpAdminPanel.TabStop = false;
            grpAdminPanel.Text = "Users List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 39);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 85);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(359, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(359, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(327, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 41);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(440, 139);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 41);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(376, 256);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 51);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back To Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(569, 328);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpAdminPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPanel";
            Load += AdminPanel_Load;
            grpAdminPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvUsers;
        private GroupBox grpAdminPanel;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
    }
}