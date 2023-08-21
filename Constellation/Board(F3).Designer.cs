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
            // 
            // tlpTopBar
            // 
            tlpTopBar.BackColor = Color.Transparent;
            tlpTopBar.ColumnCount = 7;
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 101F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 107F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 775F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 101F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 101F));
            tlpTopBar.Controls.Add(btnAddNote, 0, 0);
            tlpTopBar.Controls.Add(btnBack, 5, 0);
            tlpTopBar.Controls.Add(btnClose, 4, 0);
            tlpTopBar.Controls.Add(btnDeleteNote, 1, 0);
            tlpTopBar.Controls.Add(btnPinBoard, 2, 0);
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
            btnAddNote.Size = new Size(95, 37);
            btnAddNote.TabIndex = 0;
            btnAddNote.Tag = "Primary";
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(1178, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 37);
            btnBack.TabIndex = 1;
            btnBack.Tag = "Primary";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Fill;
            btnClose.Location = new Point(1077, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 37);
            btnClose.TabIndex = 2;
            btnClose.Tag = "Primary";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Dock = DockStyle.Fill;
            btnDeleteNote.Location = new Point(104, 3);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(101, 37);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Tag = "Primary";
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnPinBoard
            // 
            btnPinBoard.Dock = DockStyle.Fill;
            btnPinBoard.Location = new Point(211, 4);
            btnPinBoard.Margin = new Padding(3, 4, 3, 4);
            btnPinBoard.Name = "btnPinBoard";
            btnPinBoard.Size = new Size(85, 35);
            btnPinBoard.TabIndex = 4;
            btnPinBoard.Tag = "Primary";
            btnPinBoard.Text = "Pin Board";
            btnPinBoard.UseVisualStyleBackColor = true;
            btnPinBoard.Click += btnPinBoard_Click;
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
        private Button btnDeleteNote;
        private Button btnPinBoard;
    }
}