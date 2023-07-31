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
            plQuickSelect = new Panel();
            btnNewBoard = new Button();
            PanelIconHold = new Panel();
            lblUsername = new Label();
            pbUserIcon = new PictureBox();
            tlpRight = new TableLayoutPanel();
            lblBottomRight = new Label();
            lblBottomLeft = new Label();
            comingUp1 = new Controls.ComingUp();
            panelRightBarHold.SuspendLayout();
            PanelIconHold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
            tlpRight.SuspendLayout();
            SuspendLayout();
            // 
            // btnBoard
            // 
            btnBoard.Dock = DockStyle.Top;
            btnBoard.Location = new Point(0, 133);
            btnBoard.Margin = new Padding(3, 4, 3, 4);
            btnBoard.Name = "btnBoard";
            btnBoard.Size = new Size(223, 31);
            btnBoard.TabIndex = 6;
            btnBoard.Tag = "Primary";
            btnBoard.Text = "Select Board";
            btnBoard.UseVisualStyleBackColor = true;
            btnBoard.Click += btnBoard_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 772);
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
            panelRightBarHold.Controls.Add(plQuickSelect);
            panelRightBarHold.Controls.Add(btnNewBoard);
            panelRightBarHold.Controls.Add(btnBoard);
            panelRightBarHold.Controls.Add(PanelIconHold);
            panelRightBarHold.Controls.Add(btnSettings);
            panelRightBarHold.Dock = DockStyle.Left;
            panelRightBarHold.Location = new Point(0, 0);
            panelRightBarHold.Name = "panelRightBarHold";
            panelRightBarHold.Size = new Size(223, 801);
            panelRightBarHold.TabIndex = 7;
            // 
            // plQuickSelect
            // 
            plQuickSelect.AutoScroll = true;
            plQuickSelect.Dock = DockStyle.Fill;
            plQuickSelect.Location = new Point(0, 164);
            plQuickSelect.Margin = new Padding(3, 4, 3, 4);
            plQuickSelect.Name = "plQuickSelect";
            plQuickSelect.Size = new Size(223, 577);
            plQuickSelect.TabIndex = 8;
            // 
            // btnNewBoard
            // 
            btnNewBoard.Dock = DockStyle.Bottom;
            btnNewBoard.Location = new Point(0, 741);
            btnNewBoard.Margin = new Padding(3, 4, 3, 4);
            btnNewBoard.Name = "btnNewBoard";
            btnNewBoard.Size = new Size(223, 31);
            btnNewBoard.TabIndex = 7;
            btnNewBoard.Tag = "Primary";
            btnNewBoard.Text = "New Board";
            btnNewBoard.UseVisualStyleBackColor = true;
            btnNewBoard.Click += btnNewBoard_Click;
            // 
            // PanelIconHold
            // 
            PanelIconHold.BackColor = Color.Transparent;
            PanelIconHold.Controls.Add(lblUsername);
            PanelIconHold.Controls.Add(pbUserIcon);
            PanelIconHold.Dock = DockStyle.Top;
            PanelIconHold.Location = new Point(0, 0);
            PanelIconHold.Name = "PanelIconHold";
            PanelIconHold.Size = new Size(223, 133);
            PanelIconHold.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(86, 7);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // pbUserIcon
            // 
            pbUserIcon.Image = (Image)resources.GetObject("pbUserIcon.Image");
            pbUserIcon.Location = new Point(3, 7);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(75, 75);
            pbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserIcon.TabIndex = 0;
            pbUserIcon.TabStop = false;
            pbUserIcon.Click += pbUserIcon_Click;
            // 
            // tlpRight
            // 
            tlpRight.BackColor = SystemColors.ButtonFace;
            tlpRight.ColumnCount = 2;
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRight.Controls.Add(lblBottomRight, 1, 1);
            tlpRight.Controls.Add(lblBottomLeft, 0, 1);
            tlpRight.Controls.Add(comingUp1, 1, 0);
            tlpRight.Dock = DockStyle.Fill;
            tlpRight.Location = new Point(223, 0);
            tlpRight.Name = "tlpRight";
            tlpRight.RowCount = 2;
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRight.Size = new Size(1112, 801);
            tlpRight.TabIndex = 8;
            // 
            // lblBottomRight
            // 
            lblBottomRight.AutoSize = true;
            lblBottomRight.Location = new Point(559, 400);
            lblBottomRight.Name = "lblBottomRight";
            lblBottomRight.Size = new Size(116, 20);
            lblBottomRight.TabIndex = 0;
            lblBottomRight.Text = "COMING SOON ";
            // 
            // lblBottomLeft
            // 
            lblBottomLeft.AutoSize = true;
            lblBottomLeft.Location = new Point(3, 400);
            lblBottomLeft.Name = "lblBottomLeft";
            lblBottomLeft.Size = new Size(112, 20);
            lblBottomLeft.TabIndex = 3;
            lblBottomLeft.Text = "COMING SOON";
            // 
            // comingUp1
            // 
            comingUp1.Location = new Point(559, 3);
            comingUp1.Name = "comingUp1";
            comingUp1.Size = new Size(550, 394);
            comingUp1.TabIndex = 4;
            // 
            // Homepage_F1_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 801);
            Controls.Add(tlpRight);
            Controls.Add(panelRightBarHold);
            Name = "Homepage_F1_";
            Text = "Homepage_F1_";
            FormClosing += Homepage_F1__FormClosing;
            Load += Homepage_F1__Load;
            panelRightBarHold.ResumeLayout(false);
            PanelIconHold.ResumeLayout(false);
            PanelIconHold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            tlpRight.ResumeLayout(false);
            tlpRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoard;
        private Button btnSettings;
        private Panel panelRightBarHold;
        private Panel PanelIconHold;
        private PictureBox pbUserIcon;
        private TableLayoutPanel tlpRight;
        private Label lblBottomLeft;
        private Button btnNewBoard;
        private Panel plQuickSelect;
        private Label lblUsername;
        private Label lblBottomRight;
        private Controls.ComingUp comingUp1;
    }
}