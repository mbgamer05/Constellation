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
            panelRightBarHold.SuspendLayout();
            PanelIconHold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).BeginInit();
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
            pbUserIcon.Image = Properties.Resources.Screenshot_2023_04_28_185923;
            pbUserIcon.Location = new Point(10, 9);
            pbUserIcon.Name = "pbUserIcon";
            pbUserIcon.Size = new Size(75, 75);
            pbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserIcon.TabIndex = 0;
            pbUserIcon.TabStop = false;
            // 
            // Homepage_F1_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 764);
            Controls.Add(panelRightBarHold);
            Name = "Homepage_F1_";
            Text = "Homepage_F1_";
            Load += Homepage_F1__Load;
            panelRightBarHold.ResumeLayout(false);
            PanelIconHold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUserIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoard;
        private Button btnSettings;
        private Panel panelRightBarHold;
        private Panel PanelIconHold;
        private PictureBox pbUserIcon;
    }
}