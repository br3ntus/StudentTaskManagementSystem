namespace StudentTaskManagementForm
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblDb = new ToolStripStatusLabel();
            panelTop = new Panel();
            lblWelcome = new Label();
            btnLogout = new Button();
            pnlFilter = new Panel();
            rdoPending = new RadioButton();
            rdoCompleted = new RadioButton();
            label1 = new Label();
            cboFilterGroup = new ComboBox();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnDone = new Button();
            dgvTask = new DataGridView();
            statusStrip.SuspendLayout();
            panelTop.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTask).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(11, 61, 74);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, lblDb });
            statusStrip.Location = new Point(0, 543);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1085, 26);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "Database: Connected";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(244, 237, 224);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(920, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDb
            // 
            lblDb.ForeColor = Color.FromArgb(244, 237, 224);
            lblDb.Name = "lblDb";
            lblDb.Size = new Size(150, 20);
            lblDb.Text = "Database: Connected";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnLogout);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1085, 64);
            panelTop.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(16, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(232, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Username";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(11, 61, 74);
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(244, 237, 224);
            btnLogout.Location = new Point(941, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(132, 45);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnlFilter
            // 
            pnlFilter.Controls.Add(cboFilterGroup);
            pnlFilter.Controls.Add(label1);
            pnlFilter.Controls.Add(rdoCompleted);
            pnlFilter.Controls.Add(rdoPending);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 64);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(1085, 56);
            pnlFilter.TabIndex = 2;
            // 
            // rdoPending
            // 
            rdoPending.Appearance = Appearance.Button;
            rdoPending.BackColor = Color.FromArgb(11, 61, 74);
            rdoPending.Checked = true;
            rdoPending.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            rdoPending.FlatAppearance.BorderSize = 2;
            rdoPending.FlatAppearance.CheckedBackColor = Color.FromArgb(200, 240, 60);
            rdoPending.FlatStyle = FlatStyle.Flat;
            rdoPending.Font = new Font("Segoe UI", 10.2F);
            rdoPending.Location = new Point(19, 7);
            rdoPending.Name = "rdoPending";
            rdoPending.Size = new Size(114, 38);
            rdoPending.TabIndex = 0;
            rdoPending.TabStop = true;
            rdoPending.Text = "Pending";
            rdoPending.TextAlign = ContentAlignment.MiddleCenter;
            rdoPending.UseVisualStyleBackColor = false;
            // 
            // rdoCompleted
            // 
            rdoCompleted.Appearance = Appearance.Button;
            rdoCompleted.BackColor = Color.FromArgb(11, 61, 74);
            rdoCompleted.Checked = true;
            rdoCompleted.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            rdoCompleted.FlatAppearance.BorderSize = 2;
            rdoCompleted.FlatAppearance.CheckedBackColor = Color.FromArgb(200, 240, 60);
            rdoCompleted.FlatStyle = FlatStyle.Flat;
            rdoCompleted.Font = new Font("Segoe UI", 10.2F);
            rdoCompleted.ForeColor = Color.FromArgb(11, 61, 74);
            rdoCompleted.Location = new Point(146, 7);
            rdoCompleted.Name = "rdoCompleted";
            rdoCompleted.Size = new Size(114, 38);
            rdoCompleted.TabIndex = 1;
            rdoCompleted.TabStop = true;
            rdoCompleted.Text = "Completed";
            rdoCompleted.TextAlign = ContentAlignment.MiddleCenter;
            rdoCompleted.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(792, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "List Group";
            // 
            // cboFilterGroup
            // 
            cboFilterGroup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboFilterGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterGroup.FormattingEnabled = true;
            cboFilterGroup.Location = new Point(925, 15);
            cboFilterGroup.Name = "cboFilterGroup";
            cboFilterGroup.Size = new Size(148, 28);
            cboFilterGroup.TabIndex = 3;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnDone);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Dock = DockStyle.Right;
            pnlButtons.Location = new Point(895, 120);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(12);
            pnlButtons.Size = new Size(190, 423);
            pnlButtons.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(200, 240, 60);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(15, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(11, 61, 74);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(244, 237, 224);
            btnEdit.Location = new Point(15, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(11, 61, 74);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(244, 237, 224);
            btnDelete.Location = new Point(15, 159);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(11, 61, 74);
            btnDone.FlatAppearance.BorderColor = Color.FromArgb(11, 61, 74);
            btnDone.FlatAppearance.BorderSize = 2;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDone.ForeColor = Color.FromArgb(244, 237, 224);
            btnDone.Location = new Point(15, 111);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(164, 42);
            btnDone.TabIndex = 3;
            btnDone.Text = "Mark as Done";
            btnDone.UseVisualStyleBackColor = false;
            // 
            // dgvTask
            // 
            dgvTask.AllowUserToAddRows = false;
            dgvTask.AllowUserToDeleteRows = false;
            dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTask.BackgroundColor = Color.FromArgb(244, 237, 224);
            dgvTask.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 61, 74);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(244, 237, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 61, 74);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(244, 237, 224);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 61, 74);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 240, 60);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(11, 61, 74);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTask.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTask.Dock = DockStyle.Fill;
            dgvTask.EnableHeadersVisualStyles = false;
            dgvTask.Location = new Point(0, 120);
            dgvTask.MultiSelect = false;
            dgvTask.Name = "dgvTask";
            dgvTask.ReadOnly = true;
            dgvTask.RowHeadersVisible = false;
            dgvTask.RowHeadersWidth = 51;
            dgvTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTask.Size = new Size(895, 423);
            dgvTask.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 237, 224);
            ClientSize = new Size(1085, 569);
            Controls.Add(dgvTask);
            Controls.Add(pnlButtons);
            Controls.Add(pnlFilter);
            Controls.Add(panelTop);
            Controls.Add(statusStrip);
            ForeColor = Color.FromArgb(11, 61, 74);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "CRAM";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblDb;
        private Panel panelTop;
        private Button btnLogout;
        private Label lblWelcome;
        private Panel pnlFilter;
        private RadioButton rdoPending;
        private ComboBox cboFilterGroup;
        private Label label1;
        private RadioButton rdoCompleted;
        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnDone;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgvTask;
    }
}