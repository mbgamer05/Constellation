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
            txtPreview = new TextBox();
            btnSettings = new Button();
            lblNoteName = new Label();
            SuspendLayout();
            // 
            // txtPreview
            // 
            txtPreview.Location = new Point(0, 45);
            txtPreview.Multiline = true;
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(282, 80);
            txtPreview.TabIndex = 4;
            txtPreview.MouseDown += MouseDownNote;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(260, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(22, 25);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.MouseDown += MouseDownNote;
            // 
            // lblNoteName
            // 
            lblNoteName.AutoSize = true;
            lblNoteName.Location = new Point(3, 5);
            lblNoteName.Name = "lblNoteName";
            lblNoteName.Size = new Size(0, 15);
            lblNoteName.TabIndex = 5;
            // 
            // Note
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblNoteName);
            Controls.Add(txtPreview);
            Controls.Add(btnSettings);
            Name = "Note";
            Size = new Size(282, 125);
            Load += Note_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPreview;
        private Button btnSettings;
        private Label lblNoteName;
    }
}
