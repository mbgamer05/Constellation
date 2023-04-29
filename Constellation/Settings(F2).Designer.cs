namespace Constellation
{
    partial class Settings_F2_
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
            tcSettings = new TabControl();
            Graphics = new TabPage();
            combFont = new ComboBox();
            lblFont = new Label();
            tabPage2 = new TabPage();
            cbStartUp = new CheckBox();
            tcSettings.SuspendLayout();
            Graphics.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tcSettings
            // 
            tcSettings.Controls.Add(Graphics);
            tcSettings.Controls.Add(tabPage2);
            tcSettings.Dock = DockStyle.Fill;
            tcSettings.Location = new Point(0, 0);
            tcSettings.Margin = new Padding(3, 4, 3, 4);
            tcSettings.Name = "tcSettings";
            tcSettings.SelectedIndex = 0;
            tcSettings.ShowToolTips = true;
            tcSettings.Size = new Size(914, 600);
            tcSettings.TabIndex = 0;
            // 
            // Graphics
            // 
            Graphics.Controls.Add(combFont);
            Graphics.Controls.Add(lblFont);
            Graphics.Location = new Point(4, 29);
            Graphics.Margin = new Padding(3, 4, 3, 4);
            Graphics.Name = "Graphics";
            Graphics.Padding = new Padding(3, 4, 3, 4);
            Graphics.Size = new Size(906, 567);
            Graphics.TabIndex = 0;
            Graphics.Text = "Graphics";
            Graphics.UseVisualStyleBackColor = true;
            // 
            // combFont
            // 
            combFont.FormattingEnabled = true;
            combFont.Location = new Point(52, 7);
            combFont.Name = "combFont";
            combFont.Size = new Size(151, 28);
            combFont.TabIndex = 1;
            combFont.SelectedIndexChanged += combFont_SelectedIndexChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(8, 10);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(38, 20);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbStartUp);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Advanced";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbStartUp
            // 
            cbStartUp.AutoSize = true;
            cbStartUp.Location = new Point(9, 8);
            cbStartUp.Margin = new Padding(3, 4, 3, 4);
            cbStartUp.Name = "cbStartUp";
            cbStartUp.Size = new Size(152, 24);
            cbStartUp.TabIndex = 0;
            cbStartUp.Text = "Launch on start up";
            cbStartUp.UseVisualStyleBackColor = true;
            cbStartUp.CheckedChanged += cbStartUp_CheckedChanged;
            // 
            // Settings_F2_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tcSettings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings_F2_";
            Text = "Settings_F2_";
            Load += Settings_F2__Load;
            tcSettings.ResumeLayout(false);
            Graphics.ResumeLayout(false);
            Graphics.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcSettings;
        private TabPage Graphics;
        private TabPage tabPage2;
        private CheckBox cbStartUp;
        private ComboBox combFont;
        private Label lblFont;
    }
}