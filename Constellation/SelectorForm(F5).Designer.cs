namespace Constellation
{
    partial class SelectorForm_F5_
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
            tlpMainHold = new TableLayoutPanel();
            tlpTopBar = new TableLayoutPanel();
            cbSelector = new ComboBox();
            lblSelector = new Label();
            tlpBottomHold = new TableLayoutPanel();
            btnNo = new Button();
            btnYes = new Button();
            txtConfirm = new TextBox();
            tlpMainHold.SuspendLayout();
            tlpTopBar.SuspendLayout();
            tlpBottomHold.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainHold
            // 
            tlpMainHold.ColumnCount = 1;
            tlpMainHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6814156F));
            tlpMainHold.Controls.Add(tlpTopBar, 0, 0);
            tlpMainHold.Controls.Add(tlpBottomHold, 0, 1);
            tlpMainHold.Dock = DockStyle.Fill;
            tlpMainHold.Location = new Point(0, 0);
            tlpMainHold.Margin = new Padding(3, 2, 3, 2);
            tlpMainHold.Name = "tlpMainHold";
            tlpMainHold.RowCount = 2;
            tlpMainHold.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9235668F));
            tlpMainHold.RowStyles.Add(new RowStyle(SizeType.Percent, 84.07643F));
            tlpMainHold.Size = new Size(396, 181);
            tlpMainHold.TabIndex = 0;
            // 
            // tlpTopBar
            // 
            tlpTopBar.ColumnCount = 2;
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1793728F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.8206253F));
            tlpTopBar.Controls.Add(cbSelector, 1, 0);
            tlpTopBar.Controls.Add(lblSelector, 0, 0);
            tlpTopBar.Dock = DockStyle.Fill;
            tlpTopBar.Location = new Point(3, 2);
            tlpTopBar.Margin = new Padding(3, 2, 3, 2);
            tlpTopBar.Name = "tlpTopBar";
            tlpTopBar.RowCount = 1;
            tlpTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTopBar.Size = new Size(390, 24);
            tlpTopBar.TabIndex = 2;
            // 
            // cbSelector
            // 
            cbSelector.Dock = DockStyle.Fill;
            cbSelector.FormattingEnabled = true;
            cbSelector.Location = new Point(81, 2);
            cbSelector.Margin = new Padding(3, 2, 3, 2);
            cbSelector.Name = "cbSelector";
            cbSelector.Size = new Size(306, 23);
            cbSelector.TabIndex = 1;
            // 
            // lblSelector
            // 
            lblSelector.AutoSize = true;
            lblSelector.Dock = DockStyle.Fill;
            lblSelector.Location = new Point(3, 0);
            lblSelector.Name = "lblSelector";
            lblSelector.Size = new Size(72, 24);
            lblSelector.TabIndex = 2;
            lblSelector.Text = "Select";
            lblSelector.TextAlign = ContentAlignment.TopCenter;
            // 
            // tlpBottomHold
            // 
            tlpBottomHold.ColumnCount = 2;
            tlpBottomHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBottomHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBottomHold.Controls.Add(btnNo, 0, 0);
            tlpBottomHold.Controls.Add(btnYes, 1, 0);
            tlpBottomHold.Controls.Add(txtConfirm, 1, 1);
            tlpBottomHold.Dock = DockStyle.Fill;
            tlpBottomHold.Location = new Point(3, 30);
            tlpBottomHold.Margin = new Padding(3, 2, 3, 2);
            tlpBottomHold.Name = "tlpBottomHold";
            tlpBottomHold.RowCount = 2;
            tlpBottomHold.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2558136F));
            tlpBottomHold.RowStyles.Add(new RowStyle(SizeType.Percent, 76.74419F));
            tlpBottomHold.Size = new Size(390, 149);
            tlpBottomHold.TabIndex = 3;
            tlpBottomHold.Paint += tlpBottomHold_Paint;
            // 
            // btnNo
            // 
            btnNo.Location = new Point(3, 2);
            btnNo.Margin = new Padding(3, 2, 3, 2);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(82, 22);
            btnNo.TabIndex = 0;
            btnNo.Tag = "";
            btnNo.Text = "1";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.Location = new Point(198, 2);
            btnYes.Margin = new Padding(3, 2, 3, 2);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(82, 22);
            btnYes.TabIndex = 1;
            btnYes.Text = "2";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.Dock = DockStyle.Fill;
            txtConfirm.Location = new Point(198, 36);
            txtConfirm.Margin = new Padding(3, 2, 3, 2);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(189, 23);
            txtConfirm.TabIndex = 2;
            txtConfirm.Visible = false;
            // 
            // SelectorForm_F5_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 181);
            Controls.Add(tlpMainHold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SelectorForm_F5_";
            Text = "Select";
            Load += SelectorForm_F5__Load;
            tlpMainHold.ResumeLayout(false);
            tlpTopBar.ResumeLayout(false);
            tlpTopBar.PerformLayout();
            tlpBottomHold.ResumeLayout(false);
            tlpBottomHold.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMainHold;
        private ComboBox cbSelector;
        private TableLayoutPanel tlpTopBar;
        private Label lblSelector;
        private TableLayoutPanel tlpBottomHold;
        private Button btnNo;
        private Button btnYes;
        private TextBox txtConfirm;
    }
}