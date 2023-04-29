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
            tableLayoutPanel1 = new TableLayoutPanel();
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
            pTest.Location = new Point(1021, 318);
            pTest.Name = "pTest";
            pTest.Size = new Size(250, 125);
            pTest.TabIndex = 8;
            // 
            // lblPName
            // 
            lblPName.AutoSize = true;
            lblPName.Location = new Point(3, 5);
            lblPName.Name = "lblPName";
            lblPName.Size = new Size(54, 20);
            lblPName.TabIndex = 2;
            lblPName.Text = "Note 1";
            // 
            // btnPSettings
            // 
            btnPSettings.Location = new Point(221, 3);
            btnPSettings.Name = "btnPSettings";
            btnPSettings.Size = new Size(26, 27);
            btnPSettings.TabIndex = 1;
            btnPSettings.Text = "Settings";
            btnPSettings.UseVisualStyleBackColor = true;
            // 
            // txtPInput
            // 
            txtPInput.Location = new Point(3, 29);
            txtPInput.Name = "txtPInput";
            txtPInput.Size = new Size(125, 27);
            txtPInput.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(1021, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Note 2";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(221, 3);
            button1.Name = "button1";
            button1.Size = new Size(26, 27);
            button1.TabIndex = 1;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(866, 768);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // Board_F3_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 792);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pTest);
            Controls.Add(panel1);
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}