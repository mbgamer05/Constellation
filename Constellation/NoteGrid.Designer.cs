namespace Constellation
{
    partial class NoteGrid
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
            tlpStation = new TableLayoutPanel();
            Doing = new Panel();
            Done = new Panel();
            ToDo = new Panel();
            lblToDo = new Label();
            lblDoing = new Label();
            lblDone = new Label();
            tlpHoldMain = new TableLayoutPanel();
            tlpLabelHold = new TableLayoutPanel();
            tlpStation.SuspendLayout();
            tlpHoldMain.SuspendLayout();
            tlpLabelHold.SuspendLayout();
            SuspendLayout();
            // 
            // tlpStation
            // 
            tlpStation.ColumnCount = 3;
            tlpStation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpStation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpStation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tlpStation.Controls.Add(Doing, 0, 0);
            tlpStation.Controls.Add(Done, 2, 0);
            tlpStation.Controls.Add(ToDo, 0, 0);
            tlpStation.Dock = DockStyle.Fill;
            tlpStation.Location = new Point(3, 46);
            tlpStation.Name = "tlpStation";
            tlpStation.RowCount = 1;
            tlpStation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStation.Size = new Size(994, 551);
            tlpStation.TabIndex = 0;
            tlpStation.Paint += tlpPriorityHold_Paint;
            // 
            // Doing
            // 
            Doing.AutoScroll = true;
            Doing.BorderStyle = BorderStyle.FixedSingle;
            Doing.Dock = DockStyle.Fill;
            Doing.Location = new Point(334, 3);
            Doing.Name = "Doing";
            Doing.Size = new Size(325, 545);
            Doing.TabIndex = 3;
            Doing.Tag = "Basepanel";
            // 
            // Done
            // 
            Done.AutoScroll = true;
            Done.BorderStyle = BorderStyle.FixedSingle;
            Done.Dock = DockStyle.Fill;
            Done.Location = new Point(665, 3);
            Done.Name = "Done";
            Done.Size = new Size(326, 545);
            Done.TabIndex = 2;
            Done.Tag = "Basepanel";
            Done.DragDrop += DragDrop;
            Done.DragEnter += DragEnter;
            Done.DragOver += DragOver;
            Done.DragLeave += DragLeave;
            // 
            // ToDo
            // 
            ToDo.AutoScroll = true;
            ToDo.BorderStyle = BorderStyle.FixedSingle;
            ToDo.Dock = DockStyle.Fill;
            ToDo.Location = new Point(3, 3);
            ToDo.Name = "ToDo";
            ToDo.Size = new Size(325, 545);
            ToDo.TabIndex = 0;
            ToDo.Tag = "Basepanel";
            ToDo.DragDrop += DragDrop;
            ToDo.DragEnter += DragEnter;
            ToDo.DragOver += DragOver;
            ToDo.DragLeave += DragLeave;
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.ImageAlign = ContentAlignment.TopLeft;
            lblToDo.Location = new Point(3, 0);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(49, 20);
            lblToDo.TabIndex = 1;
            lblToDo.Text = "To Do";
            lblToDo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDoing
            // 
            lblDoing.AutoSize = true;
            lblDoing.Location = new Point(334, 0);
            lblDoing.Name = "lblDoing";
            lblDoing.Size = new Size(50, 20);
            lblDoing.TabIndex = 2;
            lblDoing.Text = "Doing";
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.Dock = DockStyle.Fill;
            lblDone.Location = new Point(665, 0);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(326, 37);
            lblDone.TabIndex = 3;
            lblDone.Text = "Done";
            lblDone.Click += lblDone_Click;
            // 
            // tlpHoldMain
            // 
            tlpHoldMain.ColumnCount = 1;
            tlpHoldMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHoldMain.Controls.Add(tlpLabelHold, 0, 0);
            tlpHoldMain.Controls.Add(tlpStation, 0, 1);
            tlpHoldMain.Dock = DockStyle.Fill;
            tlpHoldMain.Location = new Point(0, 0);
            tlpHoldMain.Name = "tlpHoldMain";
            tlpHoldMain.RowCount = 2;
            tlpHoldMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.24895763F));
            tlpHoldMain.RowStyles.Add(new RowStyle(SizeType.Percent, 92.7510452F));
            tlpHoldMain.Size = new Size(1000, 600);
            tlpHoldMain.TabIndex = 4;
            // 
            // tlpLabelHold
            // 
            tlpLabelHold.ColumnCount = 3;
            tlpLabelHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpLabelHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpLabelHold.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpLabelHold.Controls.Add(lblToDo, 0, 0);
            tlpLabelHold.Controls.Add(lblDone, 2, 0);
            tlpLabelHold.Controls.Add(lblDoing, 1, 0);
            tlpLabelHold.Dock = DockStyle.Fill;
            tlpLabelHold.Location = new Point(3, 3);
            tlpLabelHold.Name = "tlpLabelHold";
            tlpLabelHold.RowCount = 1;
            tlpLabelHold.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpLabelHold.Size = new Size(994, 37);
            tlpLabelHold.TabIndex = 0;
            // 
            // NoteGrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpHoldMain);
            Name = "NoteGrid";
            Size = new Size(1000, 600);
            tlpStation.ResumeLayout(false);
            tlpHoldMain.ResumeLayout(false);
            tlpLabelHold.ResumeLayout(false);
            tlpLabelHold.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpStation;
        private Panel ToDo;
        private Label lblToDo;
        private Label lblDoing;
        private Label lblDone;
        private Panel Done;
        private TableLayoutPanel tlpHoldMain;
        private TableLayoutPanel tlpLabelHold;
        private Panel Doing;
    }
}
