namespace Constellation
{
    partial class Board_F3_
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
            components = new System.ComponentModel.Container();
            tlpBody = new TableLayoutPanel();
            ng = new NoteGrid();
            tlpTopBar = new TableLayoutPanel();
            btnAddNote = new Button();
            btnBack = new Button();
            btnClose = new Button();
            timer = new System.Windows.Forms.Timer(components);
            btnTest = new Button();
            tlpBody.SuspendLayout();
            tlpTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBody
            // 
            tlpBody.BackColor = Color.Transparent;
            tlpBody.ColumnCount = 1;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.Controls.Add(ng, 0, 1);
            tlpBody.Controls.Add(tlpTopBar, 0, 0);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(0, 0);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 2;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 749F));
            tlpBody.Size = new Size(1283, 792);
            tlpBody.TabIndex = 0;
            // 
            // ng
            // 
            ng.Dock = DockStyle.Fill;
            ng.DoingColor = SystemColors.Control;
            ng.DoneColor = SystemColors.Control;
            ng.Location = new Point(3, 52);
            ng.Name = "ng";
            ng.Size = new Size(1277, 737);
            ng.TabIndex = 0;
            ng.ToDoColor = SystemColors.Control;
            ng.Load += ng_Load;
            // 
            // tlpTopBar
            // 
            tlpTopBar.BackColor = Color.Transparent;
            tlpTopBar.ColumnCount = 7;
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 775F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpTopBar.Controls.Add(btnAddNote, 0, 0);
            tlpTopBar.Controls.Add(btnBack, 5, 0);
            tlpTopBar.Controls.Add(btnClose, 4, 0);
            tlpTopBar.Controls.Add(btnTest, 1, 0);
            tlpTopBar.Dock = DockStyle.Fill;
            tlpTopBar.Location = new Point(3, 3);
            tlpTopBar.Name = "tlpTopBar";
            tlpTopBar.RowCount = 1;
            tlpTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTopBar.Size = new Size(1277, 43);
            tlpTopBar.TabIndex = 1;
            // 
            // btnAddNote
            // 
            btnAddNote.Dock = DockStyle.Fill;
            btnAddNote.Location = new Point(3, 3);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(94, 37);
            btnAddNote.TabIndex = 0;
            btnAddNote.Tag = "Primary";
            btnAddNote.Text = "Add note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(1178, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 37);
            btnBack.TabIndex = 1;
            btnBack.Tag = "Primary";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(1078, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 37);
            btnClose.TabIndex = 2;
            btnClose.Tag = "Primary";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnTest
            // 
            btnTest.Dock = DockStyle.Fill;
            btnTest.Location = new Point(103, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 37);
            btnTest.TabIndex = 3;
            btnTest.Tag = "Primary";
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // Board_F3_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 792);
            Controls.Add(tlpBody);
            Name = "Board_F3_";
            Text = "Board_F3_";
            Load += Board_F3__Load;
            tlpBody.ResumeLayout(false);
            tlpTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBody;
        private NoteGrid ng;
        private TableLayoutPanel tlpTopBar;
        private System.Windows.Forms.Timer timer;
        private Button btnAddNote;
        private Button btnBack;
        private Button btnClose;
        private Button btnTest;
    }
}