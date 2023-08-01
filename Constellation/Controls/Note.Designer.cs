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
            txtPreview = new TextBox();
            lblNoteName = new Label();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(228, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(22, 25);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // txtPreview
            // 
            txtPreview.Location = new Point(3, 40);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(244, 82);
            txtPreview.TabIndex = 4;
            // 
            // lblNoteName
            // 
            lblNoteName.AutoSize = true;
            lblNoteName.Location = new Point(0, 0);
            lblNoteName.Name = "lblNoteName";
            lblNoteName.Size = new Size(0, 20);
            lblNoteName.TabIndex = 5;
            // 
            // Note
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblNoteName);
            Controls.Add(btnSettings);
            Controls.Add(txtPreview);
            Name = "Note";
            Size = new Size(250, 125);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private TextBox txtPreview;
        private Label lblNoteName;
    }
}
