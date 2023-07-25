namespace Constellation.Controls
{
    partial class DateInformation
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
            tlpDateMainHold = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpDateMainHold
            // 
            tlpDateMainHold.ColumnCount = 1;
            tlpDateMainHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDateMainHold.Dock = DockStyle.Fill;
            tlpDateMainHold.Location = new Point(0, 0);
            tlpDateMainHold.Name = "tlpDateMainHold";
            tlpDateMainHold.RowCount = 1;
            tlpDateMainHold.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpDateMainHold.Size = new Size(338, 221);
            tlpDateMainHold.TabIndex = 0;
            // 
            // DateInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpDateMainHold);
            Name = "DateInformation";
            Size = new Size(338, 221);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpDateMainHold;
    }
}
