namespace Constellation.Controls
{
    partial class ComingUp
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
            tlpComingUp = new TableLayoutPanel();
            tlpBottomComingUp = new TableLayoutPanel();
            lbComingUpNote = new ListBox();
            tlpComingUpInfo = new TableLayoutPanel();
            txtComingUpBody = new TextBox();
            lblComingUpBoardName = new Label();
            dtpComingUpDate = new DateTimePicker();
            tlpComingUp.SuspendLayout();
            tlpBottomComingUp.SuspendLayout();
            tlpComingUpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpComingUp
            // 
            tlpComingUp.ColumnCount = 1;
            tlpComingUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpComingUp.Controls.Add(tlpBottomComingUp, 0, 1);
            tlpComingUp.Controls.Add(dtpComingUpDate, 0, 0);
            tlpComingUp.Dock = DockStyle.Fill;
            tlpComingUp.Location = new Point(0, 0);
            tlpComingUp.Margin = new Padding(3, 4, 3, 4);
            tlpComingUp.Name = "tlpComingUp";
            tlpComingUp.RowCount = 2;
            tlpComingUp.RowStyles.Add(new RowStyle(SizeType.Percent, 11.17021F));
            tlpComingUp.RowStyles.Add(new RowStyle(SizeType.Percent, 82.15063F));
            tlpComingUp.Size = new Size(535, 374);
            tlpComingUp.TabIndex = 6;
            // 
            // tlpBottomComingUp
            // 
            tlpBottomComingUp.ColumnCount = 2;
            tlpBottomComingUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.83743F));
            tlpBottomComingUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.16257F));
            tlpBottomComingUp.Controls.Add(lbComingUpNote, 0, 0);
            tlpBottomComingUp.Controls.Add(tlpComingUpInfo, 1, 0);
            tlpBottomComingUp.Dock = DockStyle.Fill;
            tlpBottomComingUp.Location = new Point(3, 47);
            tlpBottomComingUp.Name = "tlpBottomComingUp";
            tlpBottomComingUp.RowCount = 1;
            tlpBottomComingUp.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBottomComingUp.Size = new Size(529, 324);
            tlpBottomComingUp.TabIndex = 1;
            // 
            // lbComingUpNote
            // 
            lbComingUpNote.Dock = DockStyle.Fill;
            lbComingUpNote.FormattingEnabled = true;
            lbComingUpNote.ItemHeight = 20;
            lbComingUpNote.Location = new Point(3, 3);
            lbComingUpNote.Name = "lbComingUpNote";
            lbComingUpNote.Size = new Size(173, 318);
            lbComingUpNote.TabIndex = 0;
            lbComingUpNote.SelectedIndexChanged += lbComingUpNote_SelectedIndexChanged;
            // 
            // tlpComingUpInfo
            // 
            tlpComingUpInfo.ColumnCount = 1;
            tlpComingUpInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpComingUpInfo.Controls.Add(txtComingUpBody, 0, 1);
            tlpComingUpInfo.Controls.Add(lblComingUpBoardName, 0, 0);
            tlpComingUpInfo.Dock = DockStyle.Fill;
            tlpComingUpInfo.Location = new Point(182, 3);
            tlpComingUpInfo.Name = "tlpComingUpInfo";
            tlpComingUpInfo.RowCount = 2;
            tlpComingUpInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpComingUpInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 275F));
            tlpComingUpInfo.Size = new Size(344, 318);
            tlpComingUpInfo.TabIndex = 1;
            // 
            // txtComingUpBody
            // 
            txtComingUpBody.Dock = DockStyle.Fill;
            txtComingUpBody.Location = new Point(3, 46);
            txtComingUpBody.Multiline = true;
            txtComingUpBody.Name = "txtComingUpBody";
            txtComingUpBody.ReadOnly = true;
            txtComingUpBody.Size = new Size(338, 269);
            txtComingUpBody.TabIndex = 0;
            txtComingUpBody.TextChanged += txtComingUpBody_TextChanged;
            // 
            // lblComingUpBoardName
            // 
            lblComingUpBoardName.AutoSize = true;
            lblComingUpBoardName.Location = new Point(3, 0);
            lblComingUpBoardName.Name = "lblComingUpBoardName";
            lblComingUpBoardName.Size = new Size(129, 20);
            lblComingUpBoardName.TabIndex = 1;
            lblComingUpBoardName.Text = "BoardName HERE";
            // 
            // dtpComingUpDate
            // 
            dtpComingUpDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpComingUpDate.Location = new Point(3, 3);
            dtpComingUpDate.Name = "dtpComingUpDate";
            dtpComingUpDate.Size = new Size(261, 27);
            dtpComingUpDate.TabIndex = 2;
            dtpComingUpDate.CloseUp += dtpComingUpDate_CloseUp;
            // 
            // ComingUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpComingUp);
            Name = "ComingUp";
            Size = new Size(535, 374);
            tlpComingUp.ResumeLayout(false);
            tlpBottomComingUp.ResumeLayout(false);
            tlpComingUpInfo.ResumeLayout(false);
            tlpComingUpInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpComingUp;
        private TableLayoutPanel tlpBottomComingUp;
        private ListBox lbComingUpNote;
        private TableLayoutPanel tlpComingUpInfo;
        private TextBox txtComingUpBody;
        private Label lblComingUpBoardName;
        private DateTimePicker dtpComingUpDate;
    }
}
