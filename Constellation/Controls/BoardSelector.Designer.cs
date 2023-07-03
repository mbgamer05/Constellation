namespace Constellation
{
    partial class BoardSelector
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
            tlpSelectorHold = new TableLayoutPanel();
            btnLeft = new Button();
            btnRight = new Button();
            lblBoardName = new Label();
            tlpSelectorHold.SuspendLayout();
            SuspendLayout();
            // 
            // tlpSelectorHold
            // 
            tlpSelectorHold.ColumnCount = 3;
            tlpSelectorHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpSelectorHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpSelectorHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpSelectorHold.Controls.Add(btnLeft, 0, 0);
            tlpSelectorHold.Controls.Add(btnRight, 2, 0);
            tlpSelectorHold.Controls.Add(lblBoardName, 1, 0);
            tlpSelectorHold.Dock = DockStyle.Fill;
            tlpSelectorHold.Location = new Point(0, 0);
            tlpSelectorHold.Name = "tlpSelectorHold";
            tlpSelectorHold.RowCount = 1;
            tlpSelectorHold.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSelectorHold.Size = new Size(524, 47);
            tlpSelectorHold.TabIndex = 0;
            // 
            // btnLeft
            // 
            btnLeft.Dock = DockStyle.Fill;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeft.Location = new Point(3, 3);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(168, 41);
            btnLeft.TabIndex = 0;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Dock = DockStyle.Fill;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRight.Location = new Point(351, 3);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(170, 41);
            btnRight.TabIndex = 1;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // lblBoardName
            // 
            lblBoardName.AutoSize = true;
            lblBoardName.Dock = DockStyle.Fill;
            lblBoardName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBoardName.Location = new Point(177, 0);
            lblBoardName.Name = "lblBoardName";
            lblBoardName.Size = new Size(168, 47);
            lblBoardName.TabIndex = 2;
            lblBoardName.Text = "FILLTEXT";
            lblBoardName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoardSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpSelectorHold);
            Name = "BoardSelector";
            Size = new Size(524, 47);
            tlpSelectorHold.ResumeLayout(false);
            tlpSelectorHold.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpSelectorHold;
        private Button btnLeft;
        private Button btnRight;
        private Label lblBoardName;
    }
}
