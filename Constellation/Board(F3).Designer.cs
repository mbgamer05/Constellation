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
            btnDeleteNote = new Button();
            btnPinBoard = new Button();
            timer = new System.Windows.Forms.Timer(components);
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
            tlpBody.Margin = new Padding(3, 2, 3, 2);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 2;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 749F));
            tlpBody.Size = new Size(1123, 594);
            tlpBody.TabIndex = 0;
            // 
            // ng
            // 
            ng.Dock = DockStyle.Fill;
            ng.DoingColor = SystemColors.Control;
            ng.DoneColor = SystemColors.Control;
            ng.Location = new Point(3, 39);
            ng.Margin = new Padding(3, 2, 3, 2);
            ng.Name = "ng";
            ng.Size = new Size(1117, 553);
            ng.TabIndex = 0;
            ng.ToDoColor = SystemColors.Control;
            // 
            // tlpTopBar
            // 
            tlpTopBar.BackColor = Color.Transparent;
            tlpTopBar.ColumnCount = 7;
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 678F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlpTopBar.Controls.Add(btnAddNote, 0, 0);
            tlpTopBar.Controls.Add(btnBack, 5, 0);
            tlpTopBar.Controls.Add(btnClose, 4, 0);
            tlpTopBar.Controls.Add(btnDeleteNote, 1, 0);
            tlpTopBar.Controls.Add(btnPinBoard, 2, 0);
            tlpTopBar.Dock = DockStyle.Fill;
            tlpTopBar.Location = new Point(3, 2);
            tlpTopBar.Margin = new Padding(3, 2, 3, 2);
            tlpTopBar.Name = "tlpTopBar";
            tlpTopBar.RowCount = 1;
            tlpTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTopBar.Size = new Size(1117, 33);
            tlpTopBar.TabIndex = 1;
            // 
            // btnAddNote
            // 
            btnAddNote.Dock = DockStyle.Fill;
            btnAddNote.Location = new Point(3, 2);
            btnAddNote.Margin = new Padding(3, 2, 3, 2);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(82, 29);
            btnAddNote.TabIndex = 0;
            btnAddNote.Tag = "Primary";
            btnAddNote.Text = "Add note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(1031, 2);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 29);
            btnBack.TabIndex = 1;
            btnBack.Tag = "Primary";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(943, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 29);
            btnClose.TabIndex = 2;
            btnClose.Tag = "Primary";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Dock = DockStyle.Fill;
            btnDeleteNote.Location = new Point(91, 2);
            btnDeleteNote.Margin = new Padding(3, 2, 3, 2);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(88, 29);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Tag = "Primary";
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnPinBoard
            // 
            btnPinBoard.Dock = DockStyle.Fill;
            btnPinBoard.Location = new Point(185, 3);
            btnPinBoard.Name = "btnPinBoard";
            btnPinBoard.Size = new Size(74, 27);
            btnPinBoard.TabIndex = 4;
            btnPinBoard.Tag = "Primary";
            btnPinBoard.Text = "Pin Board";
            btnPinBoard.UseVisualStyleBackColor = true;
            btnPinBoard.Click += btnPinBoard_Click;
            // 
            // Board_F3_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 594);
            Controls.Add(tlpBody);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnDeleteNote;
        private Button btnPinBoard;
    }
}