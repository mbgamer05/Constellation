namespace Constellation
{
    partial class Homepage_F1_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage_F1_));
            btnBoard = new Button();
            btnSettings = new Button();
            panelRightBarHold = new Panel();
            PanelIconHold = new Panel();
            pbUserIcon = new PictureBox();
            tlpRight = new TableLayoutPanel();
            lblBottomRight = new Label();
            lblComingUp = new Label();
            lblBottomLeft = new Label();
            tlpToDoHoldTL = new TableLayoutPanel();
            lbToDoNoteNames = new ListBox();
            tlpHoldButtonsTL = new TableLayoutPanel();
            btnMove = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panelRightBarHold.SuspendLayout();
            PanelIconHold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            tlpRight.SuspendLayout();
            tlpToDoHoldTL.SuspendLayout();
            tlpHoldButtonsTL.SuspendLayout();
            SuspendLayout();
            // 
            // btnBoard
            // 
            btnBoard.Location = new Point(0, 140);
            btnBoard.Margin = new Padding(3, 4, 3, 4);
            btnBoard.Name = "btnBoard";
            btnBoard.Size = new Size(221, 31);
            btnBoard.TabIndex = 6;
            btnBoard.Tag = "Primary";
            btnBoard.Text = "Board";
            btnBoard.UseVisualStyleBackColor = true;
            btnBoard.Click += btnBoard_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 735);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(223, 29);
            btnSettings.TabIndex = 5;
            btnSettings.Tag = "Primary";
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelRightBarHold
            // 
            panelRightBarHold.BackColor = SystemColors.AppWorkspace;
            panelRightBarHold.Controls.Add(PanelIconHold);
            panelRightBarHold.Controls.Add(btnBoard);
            panelRightBarHold.Controls.Add(btnSettings);
            panelRightBarHold.Dock = DockStyle.Left;
            panelRightBarHold.Location = new Point(0, 0);
            panelRightBarHold.Name = "panelRightBarHold";
            panelRightBarHold.Size = new Size(223, 764);
            panelRightBarHold.TabIndex = 7;
            // 
            // PanelIconHold
            // 
            PanelIconHold.BackColor = Color.Transparent;
            PanelIconHold.Controls.Add(pbUserIcon);
            PanelIconHold.Dock = DockStyle.Top;
            PanelIconHold.Location = new Point(0, 0);
            PanelIconHold.Name = "PanelIconHold";
            PanelIconHold.Size = new Size(223, 133);
            PanelIconHold.TabIndex = 0;
            // 
            // pbUserIcon
            // 
            pbUserIcon.Image = (Image)resources.GetObject("pbUserIcon.Image");
            pbUserIcon.Location = new Point(10, 9);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(75, 75);
            pbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserIcon.TabIndex = 0;
            pbUserIcon.TabStop = false;
            pbUserIcon.Click += pbUserIcon_Click;
            // 
            // tlpRight
            // 
            tlpRight.ColumnCount = 2;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.Controls.Add(lblBottomRight, 1, 1);
            tlpRight.Controls.Add(lblComingUp, 1, 0);
            tlpRight.Controls.Add(lblBottomLeft, 0, 1);
            tlpRight.Controls.Add(tlpToDoHoldTL, 0, 0);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(223, 0);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 2;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.Size = new Size(1082, 764);
            tlpRight.TabIndex = 8;
            // 
            // lblBottomRight
            // 
            lblBottomRight.AutoSize = true;
            lblBottomRight.Location = new Point(544, 382);
            lblBottomRight.Name = "lblBottomRight";
            lblBottomRight.Size = new Size(116, 20);
            lblBottomRight.TabIndex = 0;
            lblBottomRight.Text = "COMING SOON ";
            // 
            // lblComingUp
            // 
            lblComingUp.AutoSize = true;
            lblComingUp.Location = new Point(544, 0);
            lblComingUp.Name = "lblComingUp";
            lblComingUp.Size = new Size(112, 20);
            lblComingUp.TabIndex = 1;
            lblComingUp.Text = "COMING SOON";
            // 
            // lblBottomLeft
            // 
            lblBottomLeft.AutoSize = true;
            lblBottomLeft.Location = new Point(3, 382);
            lblBottomLeft.Name = "lblBottomLeft";
            lblBottomLeft.Size = new Size(112, 20);
            lblBottomLeft.TabIndex = 3;
            lblBottomLeft.Text = "COMING SOON";
            // 
            // tlpToDoHoldTL
            // 
            tlpToDoHoldTL.ColumnCount = 2;
            tlpToDoHoldTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.4112167F));
            tlpToDoHoldTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.5887833F));
            tlpToDoHoldTL.Controls.Add(lbToDoNoteNames, 0, 1);
            tlpToDoHoldTL.Controls.Add(tlpHoldButtonsTL, 1, 1);
            tlpToDoHoldTL.Dock = DockStyle.Fill;
            tlpToDoHoldTL.Location = new Point(3, 3);
            tlpToDoHoldTL.Name = "tlpToDoHoldTL";
            tlpToDoHoldTL.RowCount = 2;
            tlpToDoHoldTL.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1702127F));
            tlpToDoHoldTL.RowStyles.Add(new RowStyle(SizeType.Percent, 88.82979F));
            tlpToDoHoldTL.Size = new Size(535, 376);
            tlpToDoHoldTL.TabIndex = 4;
            // 
            // lbToDoNoteNames
            // 
            lbToDoNoteNames.Dock = DockStyle.Fill;
            lbToDoNoteNames.FormattingEnabled = true;
            lbToDoNoteNames.ItemHeight = 20;
            lbToDoNoteNames.Location = new Point(3, 45);
            lbToDoNoteNames.Name = "lbToDoNoteNames";
            lbToDoNoteNames.ScrollAlwaysVisible = true;
            lbToDoNoteNames.Size = new Size(253, 328);
            lbToDoNoteNames.TabIndex = 0;
            // 
            // tlpHoldButtonsTL
            // 
            tlpHoldButtonsTL.ColumnCount = 2;
            tlpHoldButtonsTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHoldButtonsTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpHoldButtonsTL.Controls.Add(btnMove, 0, 0);
            tlpHoldButtonsTL.Controls.Add(btnDelete, 0, 2);
            tlpHoldButtonsTL.Controls.Add(btnEdit, 0, 1);
            tlpHoldButtonsTL.Dock = DockStyle.Fill;
            tlpHoldButtonsTL.Location = new Point(262, 45);
            tlpHoldButtonsTL.Name = "tlpHoldButtonsTL";
            tlpHoldButtonsTL.RowCount = 3;
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8333321F));
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1666679F));
            tlpHoldButtonsTL.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tlpHoldButtonsTL.Size = new Size(270, 328);
            tlpHoldButtonsTL.TabIndex = 1;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(3, 3);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(94, 29);
            btnMove.TabIndex = 0;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(3, 95);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Homepage_F1_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 764);
            Controls.Add(tlpRight);
            Controls.Add(panelRightBarHold);
            Name = "Homepage_F1_";
            Text = "Homepage_F1_";
            Load += Homepage_F1__Load;
            panelRightBarHold.ResumeLayout(false);
            PanelIconHold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            tlpRight.ResumeLayout(false);
            tlpRight.PerformLayout();
            tlpToDoHoldTL.ResumeLayout(false);
            tlpHoldButtonsTL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoard;
        private Button btnSettings;
        private Panel panelRightBarHold;
        private Panel PanelIconHold;
        private PictureBox pbUserIcon;
        private TableLayoutPanel tlpRight;
        private Label lblBottomRight;
        private Label lblComingUp;
        private Label lblBottomLeft;
        private TableLayoutPanel tlpToDoHoldTL;
        private ListBox lbToDoNoteNames;
        private TableLayoutPanel tlpHoldButtonsTL;
        private Button btnMove;
        private Button btnDelete;
        private Button btnEdit;
    }
}