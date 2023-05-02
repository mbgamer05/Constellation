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
            lnlName = new Label();
            tbText = new TextBox();
            SuspendLayout();
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(221, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(26, 27);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lnlName
            // 
            lnlName.AutoSize = true;
            lnlName.Location = new Point(3, 3);
            lnlName.Name = "lnlName";
            lnlName.Size = new Size(0, 20);
            lnlName.TabIndex = 3;
            // 
            // tbText
            // 
            tbText.Location = new Point(3, 51);
            tbText.Margin = new Padding(3, 4, 3, 4);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.Size = new Size(243, 70);
            tbText.TabIndex = 4;
            tbText.TextChanged += textBox1_TextChanged;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(tbText);
            Controls.Add(lnlName);
            Controls.Add(btnSettings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Note";
            Size = new Size(250, 125);
            Load += Note_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSettings;
        private Label lnlName;
        private TextBox tbText;
    }
}
