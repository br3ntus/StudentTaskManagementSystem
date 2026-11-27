namespace StudentTaskManagementForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(10, 105);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.AllowDrop = true;
            txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.ForeColor = Color.FromArgb(11, 61, 74);
            txtUsername.Location = new Point(10, 58);
            txtUsername.MaxLength = 100;
            txtUsername.Name = "txtUsername";
            txtUsername.RightToLeft = RightToLeft.Yes;
            txtUsername.Size = new Size(725, 39);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.ForeColor = Color.FromArgb(11, 61, 74);
            txtPassword.Location = new Point(10, 140);
            txtPassword.MaxLength = 30;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.Size = new Size(725, 39);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Right;
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
            btnLogin.Location = new Point(10, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(725, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(11, 61, 74);
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 14F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(10, 296);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(725, 50);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 224);
            ClientSize = new Size(747, 386);
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
            Name = "LoginForm";
            Text = "Cram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnBack;
    }
}