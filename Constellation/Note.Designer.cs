namespace Constellation
{
    partial class Note
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
            btnSettings = new Button();
            lblNoteName = new Label();
            txtPreview = new TextBox();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(223, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(24, 29);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // lblNoteName
            // 
            lblNoteName.AutoSize = true;
            lblNoteName.Location = new Point(3, 7);
            lblNoteName.Name = "lblNoteName";
            lblNoteName.Size = new Size(0, 20);
            lblNoteName.TabIndex = 3;
            // 
            // txtPreview
            // 
            txtPreview.Location = new Point(3, 42);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(244, 80);
            txtPreview.TabIndex = 4;
            // 
            // Note
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtPreview);
            Controls.Add(lblNoteName);
            Controls.Add(btnSettings);
            Name = "Note";
            Size = new Size(250, 125);
            Load += Note_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Label lblNoteName;
        private TextBox txtPreview;
    }
}
