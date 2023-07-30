namespace Constellation.Controls
{
    partial class ToDo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpToDoHoldTL = new TableLayoutPanel();
            lbToDoNoteNames = new ListBox();
            tlpHoldButtonsTL = new TableLayoutPanel();
            btnMove = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            tlpMoveButtons = new TableLayoutPanel();
            btnToDo = new Button();
            btnDoing = new Button();
            btnDone = new Button();
            bsBoards = new BannerSelector();
            tlpToDoHoldTL.SuspendLayout();
            tlpHoldButtonsTL.SuspendLayout();
            tlpMoveButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpToDoHoldTL
            // 
            tlpToDoHoldTL.ColumnCount = 2;
            tlpToDoHoldTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.41122F));
            tlpToDoHoldTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5887833F));
            tlpToDoHoldTL.Controls.Add(lbToDoNoteNames, 0, 1);
            tlpToDoHoldTL.Controls.Add(tlpHoldButtonsTL, 1, 1);
            tlpToDoHoldTL.Controls.Add(bsBoards, 0, 0);
            tlpToDoHoldTL.Dock = DockStyle.Fill;
            tlpToDoHoldTL.Location = new Point(0, 0);
            tlpToDoHoldTL.Margin = new Padding(3, 2, 3, 2);
            tlpToDoHoldTL.Name = "tlpToDoHoldTL";
            tlpToDoHoldTL.RowCount = 2;
            tlpToDoHoldTL.RowStyles.Add(new RowStyle(SizeType.Percent, 11.17021F));
            tlpToDoHoldTL.RowStyles.Add(new RowStyle(SizeType.Percent, 88.82979F));
            tlpToDoHoldTL.Size = new Size(468, 280);
            tlpToDoHoldTL.TabIndex = 5;
            // 
            // lbToDoNoteNames
            // 
            lbToDoNoteNames.Dock = DockStyle.Fill;
            lbToDoNoteNames.FormattingEnabled = true;
            lbToDoNoteNames.ItemHeight = 15;
            lbToDoNoteNames.Location = new Point(3, 33);
            lbToDoNoteNames.Margin = new Padding(3, 2, 3, 2);
            lbToDoNoteNames.Name = "lbToDoNoteNames";
            lbToDoNoteNames.ScrollAlwaysVisible = true;
            lbToDoNoteNames.Size = new Size(220, 245);
            lbToDoNoteNames.TabIndex = 0;
            lbToDoNoteNames.SelectedIndexChanged += lbToDoNoteNames_SelectedIndexChanged;
            // 
            // tlpHoldButtonsTL
            // 
            tlpHoldButtonsTL.ColumnCount = 2;
            tlpHoldButtonsTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHoldButtonsTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHoldButtonsTL.Controls.Add(btnMove, 0, 0);
            tlpHoldButtonsTL.Controls.Add(btnDelete, 0, 2);
            tlpHoldButtonsTL.Controls.Add(btnEdit, 0, 1);
            tlpHoldButtonsTL.Controls.Add(tlpMoveButtons, 1, 0);
            tlpHoldButtonsTL.Dock = DockStyle.Fill;
            tlpHoldButtonsTL.Location = new Point(229, 33);
            tlpHoldButtonsTL.Margin = new Padding(3, 2, 3, 2);
            tlpHoldButtonsTL.Name = "tlpHoldButtonsTL";
            tlpHoldButtonsTL.RowCount = 3;
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tlpHoldButtonsTL.Size = new Size(236, 245);
            tlpHoldButtonsTL.TabIndex = 1;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(3, 2);
            btnMove.Margin = new Padding(3, 2, 3, 2);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(82, 22);
            btnMove.TabIndex = 0;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 137);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(3, 83);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(82, 22);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tlpMoveButtons
            // 
            tlpMoveButtons.ColumnCount = 1;
            tlpMoveButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMoveButtons.Controls.Add(btnToDo, 0, 0);
            tlpMoveButtons.Controls.Add(btnDoing, 0, 1);
            tlpMoveButtons.Controls.Add(btnDone, 0, 2);
            tlpMoveButtons.Dock = DockStyle.Fill;
            tlpMoveButtons.Location = new Point(121, 2);
            tlpMoveButtons.Margin = new Padding(3, 2, 3, 2);
            tlpMoveButtons.Name = "tlpMoveButtons";
            tlpMoveButtons.RowCount = 3;
            tlpMoveButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpMoveButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpMoveButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tlpMoveButtons.Size = new Size(112, 77);
            tlpMoveButtons.TabIndex = 3;
            // 
            // btnToDo
            // 
            btnToDo.Dock = DockStyle.Fill;
            btnToDo.Location = new Point(3, 2);
            btnToDo.Margin = new Padding(3, 2, 3, 2);
            btnToDo.Name = "btnToDo";
            btnToDo.Size = new Size(106, 21);
            btnToDo.TabIndex = 0;
            btnToDo.Text = "ToDo";
            btnToDo.UseVisualStyleBackColor = true;
            btnToDo.Click += btnToDo_Click;
            // 
            // btnDoing
            // 
            btnDoing.Dock = DockStyle.Fill;
            btnDoing.Location = new Point(3, 27);
            btnDoing.Margin = new Padding(3, 2, 3, 2);
            btnDoing.Name = "btnDoing";
            btnDoing.Size = new Size(106, 21);
            btnDoing.TabIndex = 1;
            btnDoing.Text = "Doing";
            btnDoing.UseVisualStyleBackColor = true;
            btnDoing.Click += btnDoing_Click;
            // 
            // btnDone
            // 
            btnDone.Dock = DockStyle.Fill;
            btnDone.Location = new Point(3, 52);
            btnDone.Margin = new Padding(3, 2, 3, 2);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(106, 23);
            btnDone.TabIndex = 2;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // bsBoards
            // 
            bsBoards.BannerText = "FILLTEXT";
            bsBoards.Dock = DockStyle.Fill;
            bsBoards.Location = new Point(3, 4);
            bsBoards.Margin = new Padding(3, 4, 3, 4);
            bsBoards.Name = "bsBoards";
            bsBoards.Size = new Size(220, 23);
            bsBoards.TabIndex = 2;
            bsBoards.Load += bsBoards_Load;
            // 
            // ToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpToDoHoldTL);
            Name = "ToDo";
            Size = new Size(468, 280);
            tlpToDoHoldTL.ResumeLayout(false);
            tlpHoldButtonsTL.ResumeLayout(false);
            tlpMoveButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpToDoHoldTL;
        private ListBox lbToDoNoteNames;
        private TableLayoutPanel tlpHoldButtonsTL;
        private Button btnMove;
        private Button btnDelete;
        private Button btnEdit;
        private TableLayoutPanel tlpMoveButtons;
        private Button btnToDo;
        private Button btnDoing;
        private Button btnDone;
        private BannerSelector bsBoards;
    }
}
