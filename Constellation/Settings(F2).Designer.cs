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
            btnCancel = new Button();
            btnBack = new Button();
            btnApply = new Button();
            btnTextColour = new Button();
            btnTextboxBackgroundColour = new Button();
            btnBackgroundColour = new Button();
            btnSecondaryColour = new Button();
            btnPrimaryColour = new Button();
            panelPreview = new Panel();
            txtPreview = new TextBox();
            btnSecondary = new Button();
            btnPrimary = new Button();
            lblCustomSchemes = new Label();
            comboBox1 = new ComboBox();
            rbSchemeThree = new RadioButton();
            rbSchemeTwo = new RadioButton();
            rbSchemeOne = new RadioButton();
            lblPresets = new Label();
            lblReadability = new Label();
            lblTextColour = new Label();
            lblBackgroundColour = new Label();
            lblButtonsColour = new Label();
            lblColourScheme = new Label();
            combFont = new ComboBox();
            lblFont = new Label();
            tabPage2 = new TabPage();
            cbStartUp = new CheckBox();
            ColourD = new ColorDialog();
            tcSettings.SuspendLayout();
            Graphics.SuspendLayout();
            panelPreview.SuspendLayout();
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
            Graphics.Controls.Add(btnCancel);
            Graphics.Controls.Add(btnBack);
            Graphics.Controls.Add(btnApply);
            Graphics.Controls.Add(btnTextColour);
            Graphics.Controls.Add(btnTextboxBackgroundColour);
            Graphics.Controls.Add(btnBackgroundColour);
            Graphics.Controls.Add(btnSecondaryColour);
            Graphics.Controls.Add(btnPrimaryColour);
            Graphics.Controls.Add(panelPreview);
            Graphics.Controls.Add(lblCustomSchemes);
            Graphics.Controls.Add(comboBox1);
            Graphics.Controls.Add(rbSchemeThree);
            Graphics.Controls.Add(rbSchemeTwo);
            Graphics.Controls.Add(rbSchemeOne);
            Graphics.Controls.Add(lblPresets);
            Graphics.Controls.Add(lblReadability);
            Graphics.Controls.Add(lblTextColour);
            Graphics.Controls.Add(lblBackgroundColour);
            Graphics.Controls.Add(lblButtonsColour);
            Graphics.Controls.Add(lblColourScheme);
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
            // btnCancel
            // 
            btnCancel.Location = new Point(804, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Tag = "Primary";
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(804, 77);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 23;
            btnBack.Tag = "Primary";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(804, 7);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(94, 29);
            btnApply.TabIndex = 23;
            btnApply.Tag = "Primary";
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnTextColour
            // 
            btnTextColour.Location = new Point(52, 242);
            btnTextColour.Name = "btnTextColour";
            btnTextColour.Size = new Size(151, 28);
            btnTextColour.TabIndex = 22;
            btnTextColour.Tag = "Primary";
            btnTextColour.Text = "Text Colour";
            btnTextColour.UseVisualStyleBackColor = true;
            btnTextColour.Click += btnTextColour_Click;
            // 
            // btnTextboxBackgroundColour
            // 
            btnTextboxBackgroundColour.Location = new Point(52, 276);
            btnTextboxBackgroundColour.Name = "btnTextboxBackgroundColour";
            btnTextboxBackgroundColour.Size = new Size(214, 28);
            btnTextboxBackgroundColour.TabIndex = 21;
            btnTextboxBackgroundColour.Tag = "Secondary";
            btnTextboxBackgroundColour.Text = "Textbox background Colour";
            btnTextboxBackgroundColour.UseVisualStyleBackColor = true;
            btnTextboxBackgroundColour.Click += btnTextboxBackgroundColour_Click;
            // 
            // btnBackgroundColour
            // 
            btnBackgroundColour.Location = new Point(52, 171);
            btnBackgroundColour.Name = "btnBackgroundColour";
            btnBackgroundColour.Size = new Size(151, 28);
            btnBackgroundColour.TabIndex = 20;
            btnBackgroundColour.Tag = "Primary";
            btnBackgroundColour.Text = "Background Colour";
            btnBackgroundColour.UseVisualStyleBackColor = true;
            btnBackgroundColour.Click += btnBackgroundColour_Click;
            // 
            // btnSecondaryColour
            // 
            btnSecondaryColour.Location = new Point(52, 96);
            btnSecondaryColour.Name = "btnSecondaryColour";
            btnSecondaryColour.Size = new Size(151, 28);
            btnSecondaryColour.TabIndex = 19;
            btnSecondaryColour.Tag = "Secondary";
            btnSecondaryColour.Text = "Secondary Button";
            btnSecondaryColour.UseVisualStyleBackColor = true;
            btnSecondaryColour.Click += btnSecondaryColour_Click;
            // 
            // btnPrimaryColour
            // 
            btnPrimaryColour.Location = new Point(52, 62);
            btnPrimaryColour.Name = "btnPrimaryColour";
            btnPrimaryColour.Size = new Size(151, 28);
            btnPrimaryColour.TabIndex = 18;
            btnPrimaryColour.Tag = "Primary";
            btnPrimaryColour.Text = "Primary Button";
            btnPrimaryColour.UseVisualStyleBackColor = true;
            btnPrimaryColour.Click += btnPrimaryColour_Click;
            // 
            // panelPreview
            // 
            panelPreview.Controls.Add(txtPreview);
            panelPreview.Controls.Add(btnSecondary);
            panelPreview.Controls.Add(btnPrimary);
            panelPreview.Location = new Point(279, 372);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new Size(347, 187);
            panelPreview.TabIndex = 17;
            // 
            // txtPreview
            // 
            txtPreview.BackColor = SystemColors.HighlightText;
            txtPreview.Location = new Point(170, 7);
            txtPreview.Name = "txtPreview";
            txtPreview.Size = new Size(166, 27);
            txtPreview.TabIndex = 2;
            txtPreview.Text = "Sample text shown here";
            // 
            // btnSecondary
            // 
            btnSecondary.Location = new Point(3, 88);
            btnSecondary.Name = "btnSecondary";
            btnSecondary.Size = new Size(161, 75);
            btnSecondary.TabIndex = 1;
            btnSecondary.Text = "Secondary Button Preview";
            btnSecondary.UseVisualStyleBackColor = true;
            // 
            // btnPrimary
            // 
            btnPrimary.Location = new Point(3, 7);
            btnPrimary.Name = "btnPrimary";
            btnPrimary.Size = new Size(161, 75);
            btnPrimary.TabIndex = 0;
            btnPrimary.Text = "Primary Button Preview";
            btnPrimary.UseVisualStyleBackColor = true;
            // 
            // lblCustomSchemes
            // 
            lblCustomSchemes.AutoSize = true;
            lblCustomSchemes.Location = new Point(8, 460);
            lblCustomSchemes.Name = "lblCustomSchemes";
            lblCustomSchemes.Size = new Size(121, 20);
            lblCustomSchemes.TabIndex = 16;
            lblCustomSchemes.Text = "Custom Schemes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, 483);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // rbSchemeThree
            // 
            rbSchemeThree.AutoSize = true;
            rbSchemeThree.Location = new Point(8, 432);
            rbSchemeThree.Name = "rbSchemeThree";
            rbSchemeThree.Size = new Size(94, 24);
            rbSchemeThree.TabIndex = 14;
            rbSchemeThree.TabStop = true;
            rbSchemeThree.Text = "Scheme 3";
            rbSchemeThree.UseVisualStyleBackColor = true;
            rbSchemeThree.CheckedChanged += rbSchemeThree_CheckedChanged;
            // 
            // rbSchemeTwo
            // 
            rbSchemeTwo.AutoSize = true;
            rbSchemeTwo.Location = new Point(8, 402);
            rbSchemeTwo.Name = "rbSchemeTwo";
            rbSchemeTwo.Size = new Size(94, 24);
            rbSchemeTwo.TabIndex = 13;
            rbSchemeTwo.TabStop = true;
            rbSchemeTwo.Text = "Scheme 2";
            rbSchemeTwo.UseVisualStyleBackColor = true;
            rbSchemeTwo.CheckedChanged += rbSchemeTwo_CheckedChanged;
            // 
            // rbSchemeOne
            // 
            rbSchemeOne.AutoSize = true;
            rbSchemeOne.Location = new Point(8, 372);
            rbSchemeOne.Name = "rbSchemeOne";
            rbSchemeOne.Size = new Size(94, 24);
            rbSchemeOne.TabIndex = 12;
            rbSchemeOne.TabStop = true;
            rbSchemeOne.Text = "Scheme 1";
            rbSchemeOne.UseVisualStyleBackColor = true;
            rbSchemeOne.CheckedChanged += rbSchemeOne_CheckedChanged;
            // 
            // lblPresets
            // 
            lblPresets.AutoSize = true;
            lblPresets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresets.Location = new Point(8, 328);
            lblPresets.Name = "lblPresets";
            lblPresets.Size = new Size(210, 28);
            lblPresets.TabIndex = 11;
            lblPresets.Text = "Preset Colour Schemes";
            // 
            // lblReadability
            // 
            lblReadability.AutoSize = true;
            lblReadability.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblReadability.Location = new Point(337, 4);
            lblReadability.Name = "lblReadability";
            lblReadability.Size = new Size(109, 28);
            lblReadability.TabIndex = 10;
            lblReadability.Text = "Readability";
            // 
            // lblTextColour
            // 
            lblTextColour.AutoSize = true;
            lblTextColour.Location = new Point(8, 219);
            lblTextColour.Name = "lblTextColour";
            lblTextColour.Size = new Size(84, 20);
            lblTextColour.TabIndex = 9;
            lblTextColour.Text = "Text Colour";
            // 
            // lblBackgroundColour
            // 
            lblBackgroundColour.AutoSize = true;
            lblBackgroundColour.Location = new Point(8, 148);
            lblBackgroundColour.Name = "lblBackgroundColour";
            lblBackgroundColour.Size = new Size(136, 20);
            lblBackgroundColour.TabIndex = 7;
            lblBackgroundColour.Text = "Background Colour";
            // 
            // lblButtonsColour
            // 
            lblButtonsColour.AutoSize = true;
            lblButtonsColour.Location = new Point(8, 39);
            lblButtonsColour.Name = "lblButtonsColour";
            lblButtonsColour.Size = new Size(101, 20);
            lblButtonsColour.TabIndex = 6;
            lblButtonsColour.Text = "Button Colour";
            // 
            // lblColourScheme
            // 
            lblColourScheme.AutoSize = true;
            lblColourScheme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblColourScheme.Location = new Point(8, 4);
            lblColourScheme.Name = "lblColourScheme";
            lblColourScheme.Size = new Size(152, 28);
            lblColourScheme.TabIndex = 2;
            lblColourScheme.Text = "Colour Schemes";
            lblColourScheme.Click += label1_Click;
            // 
            // combFont
            // 
            combFont.FormattingEnabled = true;
            combFont.Location = new Point(381, 62);
            combFont.Name = "combFont";
            combFont.Size = new Size(151, 28);
            combFont.TabIndex = 1;
            combFont.SelectedIndexChanged += combFont_SelectedIndexChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(337, 39);
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
            ControlBox = false;
            Controls.Add(tcSettings);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings_F2_";
            Text = "Settings_F2_";
            Load += Settings_F2__Load;
            tcSettings.ResumeLayout(false);
            Graphics.ResumeLayout(false);
            Graphics.PerformLayout();
            panelPreview.ResumeLayout(false);
            panelPreview.PerformLayout();
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
        private Label lblColourScheme;
        private Label lblTextColour;
        private Label lblBackgroundColour;
        private Label lblButtonsColour;
        private Label lblReadability;
        private Label lblPresets;
        private RadioButton rbSchemeThree;
        private RadioButton rbSchemeTwo;
        private RadioButton rbSchemeOne;
        private Panel panelPreview;
        private TextBox txtPreview;
        private Button btnSecondary;
        private Button btnPrimary;
        private Label lblCustomSchemes;
        private ComboBox comboBox1;
        private Button btnTextboxBackgroundColour;
        private Button btnBackgroundColour;
        private Button btnSecondaryColour;
        private Button btnPrimaryColour;
        private Button btnTextColour;
        private ColorDialog ColourD;


        private void main()
        {

        }

        private Button btnCancel;
        private Button btnBack;
        private Button btnApply;
    }

}