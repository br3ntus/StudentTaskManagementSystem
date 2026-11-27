namespace StudentTaskManagementForm
{
    partial class EntrySelectionWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrySelectionWindow));
            btnRegister = new Button();
            lblTitle = new Label();
            btnLogIn = new Button();
            btnExit = new Button();
            lblsup = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRegister.BackColor = Color.FromArgb(11, 61, 74);
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(33, 253);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(562, 59);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += registerBtn_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(244, 237, 224);
            lblTitle.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(11, 61, 74);
            lblTitle.Location = new Point(198, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(226, 73);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "CRAM";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnLogIn.BackColor = Color.FromArgb(200, 240, 60);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnLogIn.FlatAppearance.BorderSize = 2;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.FromArgb(11, 61, 74);
            btnLogIn.Location = new Point(33, 169);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(562, 59);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += logInBtn_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnExit.BackColor = Color.FromArgb(11, 61, 74);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(33, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(562, 59);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += exitBtn_Click;
            // 
            // lblsup
            // 
            lblsup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblsup.AutoSize = true;
            lblsup.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsup.ForeColor = SystemColors.ControlDarkDark;
            lblsup.Location = new Point(217, 111);
            lblsup.Name = "lblsup";
            lblsup.Size = new Size(186, 25);
            lblsup.TabIndex = 4;
            lblsup.Text = "Student Task Manager";
            // 
            // EntrySelectionWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 224);
            ClientSize = new Size(629, 450);
            Controls.Add(lblsup);
            Controls.Add(btnExit);
            Controls.Add(btnLogIn);
            Controls.Add(lblTitle);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntrySelectionWindow";
            Text = "Cram";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label lblTitle;
        private Button btnLogIn;
        private Button btnExit;
        private Label lblsup;
    }
}
