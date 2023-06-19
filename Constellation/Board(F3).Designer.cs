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
            components = new System.ComponentModel.Container();
            tlpBody = new TableLayoutPanel();
            ng = new NoteGrid();
            tlpTopBar = new TableLayoutPanel();
            timer = new System.Windows.Forms.Timer(components);
            tlpBody.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBody
            // 
            tlpBody.BackColor = Color.Transparent;
            tlpBody.ColumnCount = 1;
            tlpBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBody.Controls.Add(ng, 0, 1);
            tlpBody.Controls.Add(tlpTopBar, 0, 0);
            tlpBody.Dock = DockStyle.Fill;
            tlpBody.Location = new Point(0, 0);
            tlpBody.Name = "tlpBody";
            tlpBody.RowCount = 2;
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBody.RowStyles.Add(new RowStyle(SizeType.Absolute, 749F));
            tlpBody.Size = new Size(1283, 792);
            tlpBody.TabIndex = 0;
            // 
            // ng
            // 
            ng.Dock = DockStyle.Fill;
            ng.DoingColor = SystemColors.Control;
            ng.DoneColor = SystemColors.Control;
            ng.Location = new Point(3, 46);
            ng.Name = "ng";
            ng.Size = new Size(1277, 743);
            ng.TabIndex = 0;
            ng.ToDoColor = SystemColors.Control;
            // 
            // tlpTopBar
            // 
            tlpTopBar.BackColor = Color.Transparent;
            tlpTopBar.ColumnCount = 7;
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 921F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tlpTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tlpTopBar.Dock = DockStyle.Fill;
            tlpTopBar.Location = new Point(3, 3);
            tlpTopBar.Name = "tlpTopBar";
            tlpTopBar.RowCount = 1;
            tlpTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTopBar.Size = new Size(1277, 37);
            tlpTopBar.TabIndex = 1;
            // 
            // Board_F3_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 792);
            Controls.Add(tlpBody);
            Name = "Board_F3_";
            Text = "Board_F3_";
            Load += Board_F3__Load;
            tlpBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBody;
        private NoteGrid ng;
        private TableLayoutPanel tlpTopBar;
        private System.Windows.Forms.Timer timer;
    }
}