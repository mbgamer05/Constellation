namespace Constellation
{
    partial class NoteExpanded_F4_
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
            tlpBody = new TableLayoutPanel();
            txtBody = new TextBox();
            txtPreview = new TextBox();
            lblName = new Label();
            lblPreview = new Label();
            lblBody = new Label();
            lblDate = new Label();
            btnCancel = new Button();
            txtName = new TextBox();
            dtpDate = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnApply = new Button();
            btnClose = new Button();
            tlpBody.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBody
            // 
            tlpBody.ColumnCount = 2;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.Controls.Add(txtBody, 1, 2);
            tlpBody.Controls.Add(txtPreview, 1, 1);
            tlpBody.Controls.Add(lblName, 0, 0);
            tlpBody.Controls.Add(lblPreview, 0, 1);
            tlpBody.Controls.Add(lblBody, 0, 2);
            tlpBody.Controls.Add(lblDate, 0, 3);
            tlpBody.Controls.Add(btnCancel, 0, 4);
            tlpBody.Controls.Add(txtName, 1, 0);
            tlpBody.Controls.Add(dtpDate, 1, 3);
            tlpBody.Controls.Add(tableLayoutPanel1, 1, 4);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(0, 0);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 5;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tlpBody.Size = new Size(583, 414);
            tlpBody.TabIndex = 0;
            // 
            // txtBody
            // 
            txtBody.Dock = DockStyle.Fill;
            txtBody.Location = new Point(294, 167);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ScrollBars = ScrollBars.Vertical;
            txtBody.Size = new Size(286, 76);
            txtBody.TabIndex = 8;
            // 
            // txtPreview
            // 
            txtPreview.Dock = DockStyle.Fill;
            txtPreview.Location = new Point(294, 85);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(286, 76);
            txtPreview.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Location = new Point(3, 82);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(44, 20);
            lblPreview.TabIndex = 3;
            lblPreview.Text = "Blurb";
            // 
            // lblBody
            // 
            lblBody.AutoSize = true;
            lblBody.Location = new Point(3, 164);
            lblBody.Name = "lblBody";
            lblBody.Size = new Size(87, 20);
            lblBody.TabIndex = 5;
            lblBody.Text = "Information";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 246);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(3, 331);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(294, 3);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 76);
            txtName.TabIndex = 6;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(294, 249);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(186, 27);
            dtpDate.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnApply, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClose, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(294, 331);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(286, 80);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(3, 3);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 10;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(3, 43);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 27);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Visible = false;
            btnClose.Click += btnClose_Click;
            // 
            // NoteExpanded_F4_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 414);
            ControlBox = false;
            Controls.Add(tlpBody);
            Name = "NoteExpanded_F4_";
            Text = "NoteExpanded_F4_";
            Load += NoteExpanded_F4__Load;
            tlpBody.ResumeLayout(false);
            tlpBody.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBody;
        private Button btnCancel;
        private Label lblName;
        private Label lblPreview;
        private Label lblBody;
        private Label lblDate;
        private TextBox txtPreview;
        private TextBox txtName;
        private TextBox txtBody;
        private DateTimePicker dtpDate;
        private Button btnApply;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel1;
    }
}