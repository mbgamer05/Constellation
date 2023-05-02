namespace Constellation
{
    partial class Board_F3_
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
            pTest = new Panel();
            lblPName = new Label();
            btnPSettings = new Button();
            txtPInput = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            note1 = new Note();
            pTest.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pTest
            // 
            pTest.BackColor = SystemColors.ActiveCaption;
            pTest.Controls.Add(lblPName);
            pTest.Controls.Add(btnPSettings);
            pTest.Controls.Add(txtPInput);
            pTest.Location = new Point(1263, 238);
            pTest.Margin = new Padding(3, 2, 3, 2);
            pTest.Name = "pTest";
            pTest.Size = new Size(219, 94);
            pTest.TabIndex = 8;
            pTest.Paint += pTest_Paint;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(3, 4);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(42, 15);
            lblPName.TabIndex = 2;
            lblPName.Text = "Note 1";
            // 
            // btnPSettings
            // 
            btnPSettings.Location = new Point(193, 2);
            btnPSettings.Margin = new Padding(3, 2, 3, 2);
            btnPSettings.Name = "btnPSettings";
            btnPSettings.Size = new Size(23, 20);
            btnPSettings.TabIndex = 1;
            btnPSettings.Text = "Settings";
            btnPSettings.UseVisualStyleBackColor = true;
            // 
            // txtPInput
            // 
            txtPInput.Location = new Point(3, 22);
            txtPInput.Margin = new Padding(3, 2, 3, 2);
            txtPInput.Name = "txtPInput";
            txtPInput.Size = new Size(110, 23);
            txtPInput.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(1263, 140);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 94);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Note 2";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(193, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(23, 20);
            button1.TabIndex = 1;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 22);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // note1
            // 
            note1.BackColor = SystemColors.ActiveCaption;
            note1.Location = new Point(990, 228);
            note1.Name = "note1";
            note1.Size = new Size(219, 94);
            note1.TabIndex = 10;
            // 
            // Board_F3_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 863);
            Controls.Add(note1);
            Controls.Add(pTest);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Board_F3_";
            Text = "Board_F3_";
            Load += Board_F3__Load;
            pTest.ResumeLayout(false);
            pTest.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pTest;
        private Label lblPName;
        private Button btnPSettings;
        private TextBox txtPInput;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Note note1;
    }
}