namespace StudentTaskManagementForm
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btnBack = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirm = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(11, 61, 74);
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 14F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(33, 361);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(725, 50);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(200, 240, 60);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 14F);
            btnLogin.ForeColor = Color.FromArgb(11, 61, 74);
            btnLogin.Location = new Point(33, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(725, 50);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Register";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(11, 61, 74);
            txtPassword.Location = new Point(33, 129);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(725, 38);
            txtPassword.TabIndex = 9;
            txtPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(11, 61, 74);
            txtUsername.Location = new Point(33, 49);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Size = new Size(725, 38);
            txtUsername.TabIndex = 8;
            txtUsername.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // txtConfirm
            // 
            txtConfirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtConfirm.BackColor = Color.White;
            txtConfirm.Font = new Font("Segoe UI", 14F);
            txtConfirm.ForeColor = Color.FromArgb(11, 61, 74);
            txtConfirm.Location = new Point(33, 210);
            txtConfirm.MaxLength = 30;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.RightToLeft = RightToLeft.Yes;
            txtConfirm.Size = new Size(725, 39);
            txtConfirm.TabIndex = 13;
            txtConfirm.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(33, 175);
            label3.Name = "label3";
            label3.Size = new Size(204, 32);
            label3.TabIndex = 12;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 224);
            ClientSize = new Size(800, 461);
            Controls.Add(txtConfirm);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(11, 61, 74);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            Text = "CRAM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtConfirm;
        private Label label3;
    }
}