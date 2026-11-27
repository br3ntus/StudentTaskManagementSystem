namespace StudentTaskManagementForm
{
    partial class AddTaskForm
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtDue = new DateTimePicker();
            label3 = new Label();
            cboRepeat = new ComboBox();
            label4 = new Label();
            cboGroup = new ComboBox();
            label5 = new Label();
            tctDescription = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(11, 61, 74);
            txtTitle.Location = new Point(19, 57);
            txtTitle.MaxLength = 100;
            txtTitle.Name = "txtTitle";
            txtTitle.RightToLeft = RightToLeft.Yes;
            txtTitle.Size = new Size(518, 38);
            txtTitle.TabIndex = 4;
            txtTitle.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 3;
            label1.Text = "Task Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 5;
            label2.Text = "Due Date";
            label2.Click += label2_Click;
            // 
            // dtDue
            // 
            dtDue.Format = DateTimePickerFormat.Short;
            dtDue.Location = new Point(19, 141);
            dtDue.Name = "dtDue";
            dtDue.ShowCheckBox = true;
            dtDue.Size = new Size(518, 27);
            dtDue.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 186);
            label3.Name = "label3";
            label3.Size = new Size(184, 31);
            label3.TabIndex = 7;
            label3.Text = "Repeat Schedule";
            // 
            // cboRepeat
            // 
            cboRepeat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRepeat.FormattingEnabled = true;
            cboRepeat.Location = new Point(19, 220);
            cboRepeat.Name = "cboRepeat";
            cboRepeat.Size = new Size(518, 28);
            cboRepeat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 267);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 9;
            label4.Text = "List Group";
            // 
            // cboGroup
            // 
            cboGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGroup.FormattingEnabled = true;
            cboGroup.Location = new Point(19, 301);
            cboGroup.Name = "cboGroup";
            cboGroup.Size = new Size(518, 28);
            cboGroup.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 349);
            label5.Name = "label5";
            label5.Size = new Size(131, 31);
            label5.TabIndex = 11;
            label5.Text = "Description";
            // 
            // tctDescription
            // 
            tctDescription.Location = new Point(19, 383);
            tctDescription.MaxLength = 500;
            tctDescription.Multiline = true;
            tctDescription.Name = "tctDescription";
            tctDescription.ScrollBars = ScrollBars.Vertical;
            tctDescription.Size = new Size(518, 89);
            tctDescription.TabIndex = 12;
            tctDescription.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.None;
            btnCreate.BackColor = Color.FromArgb(200, 240, 60);
            btnCreate.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnCreate.FlatAppearance.BorderSize = 2;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.FromArgb(11, 61, 74);
            btnCreate.Location = new Point(19, 495);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(518, 50);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create Task";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(11, 61, 74);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(244, 237, 224);
            btnCancel.Location = new Point(19, 551);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(518, 50);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 224);
            ClientSize = new Size(562, 620);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(tctDescription);
            Controls.Add(label5);
            Controls.Add(cboGroup);
            Controls.Add(label4);
            Controls.Add(cboRepeat);
            Controls.Add(label3);
            Controls.Add(dtDue);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(11, 61, 74);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTaskForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private DateTimePicker dtDue;
        private Label label3;
        private ComboBox cboRepeat;
        private Label label4;
        private ComboBox cboGroup;
        private Label label5;
        private TextBox tctDescription;
        private Button btnCreate;
        private Button btnCancel;
    }
}