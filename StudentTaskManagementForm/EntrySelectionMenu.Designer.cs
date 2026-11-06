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
            registerBtn = new Button();
            TitleLabel = new Label();
            logInBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.BackColor = SystemColors.ActiveCaption;
            registerBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.Location = new Point(336, 113);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(203, 59);
            registerBtn.TabIndex = 0;
            registerBtn.Text = "REGISTER";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = SystemColors.ActiveCaption;
            TitleLabel.Font = new Font("Verdana", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(55, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(765, 53);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "STUDENT TASK MANAGEMENT";
            TitleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = SystemColors.ActiveCaption;
            logInBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logInBtn.Location = new Point(336, 178);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(203, 59);
            logInBtn.TabIndex = 2;
            logInBtn.Text = "LOG-IN ";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = SystemColors.ActiveCaption;
            exitBtn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(336, 243);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(203, 59);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // EntrySelectionWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(878, 450);
            Controls.Add(exitBtn);
            Controls.Add(logInBtn);
            Controls.Add(TitleLabel);
            Controls.Add(registerBtn);
            Name = "EntrySelectionWindow";
            Text = "Student Task Management";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerBtn;
        private Label TitleLabel;
        private Button logInBtn;
        private Button exitBtn;
    }
}
