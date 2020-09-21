namespace Swan
{
    partial class TileStopwatch
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.lapLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkFR = new System.Windows.Forms.CheckBox();
            this.checkBK = new System.Windows.Forms.CheckBox();
            this.checkBR = new System.Windows.Forms.CheckBox();
            this.checkBU = new System.Windows.Forms.CheckBox();
            this.checkIM = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.check25 = new System.Windows.Forms.CheckBox();
            this.check50 = new System.Windows.Forms.CheckBox();
            this.check75 = new System.Windows.Forms.CheckBox();
            this.check100 = new System.Windows.Forms.CheckBox();
            this.check200 = new System.Windows.Forms.CheckBox();
            this.check400 = new System.Windows.Forms.CheckBox();
            this.check800 = new System.Windows.Forms.CheckBox();
            this.check1500 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnLap = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.splitLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lapsHeadLabel = new System.Windows.Forms.Label();
            this.splitsHeadLabel = new System.Windows.Forms.Label();
            this.lastLapsLabel = new System.Windows.Forms.Label();
            this.lastSplitsLabel = new System.Windows.Forms.Label();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.lastSameEventLabel = new System.Windows.Forms.Label();
            this.lastSameEventSplitsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.timeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(1, 1);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(192, 43);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::Swan.Properties.Resources.save_lowop;
            this.btnSave.Location = new System.Drawing.Point(194, 1);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 43);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSave.TabIndex = 2;
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lapLabel
            // 
            this.lapLabel.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.lapLabel, 2);
            this.lapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapLabel.Location = new System.Drawing.Point(0, 0);
            this.lapLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lapLabel.Name = "lapLabel";
            this.lapLabel.Size = new System.Drawing.Size(230, 30);
            this.lapLabel.TabIndex = 2;
            this.lapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lapLabel.Click += new System.EventHandler(this.toggleLastLaps);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 23);
            this.nameLabel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.checkFR, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBR, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBU, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkIM, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 154);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 50);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // checkFR
            // 
            this.checkFR.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkFR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkFR.FlatAppearance.BorderSize = 0;
            this.checkFR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFR.Location = new System.Drawing.Point(0, 0);
            this.checkFR.Margin = new System.Windows.Forms.Padding(0);
            this.checkFR.Name = "checkFR";
            this.checkFR.Size = new System.Drawing.Size(46, 50);
            this.checkFR.TabIndex = 5;
            this.checkFR.Text = "FR";
            this.checkFR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkFR.UseVisualStyleBackColor = true;
            this.checkFR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkStyle_Click);
            // 
            // checkBK
            // 
            this.checkBK.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBK.FlatAppearance.BorderSize = 0;
            this.checkBK.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBK.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBK.Location = new System.Drawing.Point(46, 0);
            this.checkBK.Margin = new System.Windows.Forms.Padding(0);
            this.checkBK.Name = "checkBK";
            this.checkBK.Size = new System.Drawing.Size(46, 50);
            this.checkBK.TabIndex = 6;
            this.checkBK.Text = "BK";
            this.checkBK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBK.UseVisualStyleBackColor = true;
            this.checkBK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkStyle_Click);
            // 
            // checkBR
            // 
            this.checkBR.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBR.FlatAppearance.BorderSize = 0;
            this.checkBR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBR.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBR.Location = new System.Drawing.Point(92, 0);
            this.checkBR.Margin = new System.Windows.Forms.Padding(0);
            this.checkBR.Name = "checkBR";
            this.checkBR.Size = new System.Drawing.Size(46, 50);
            this.checkBR.TabIndex = 7;
            this.checkBR.Text = "BR";
            this.checkBR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBR.UseVisualStyleBackColor = true;
            this.checkBR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkStyle_Click);
            // 
            // checkBU
            // 
            this.checkBU.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBU.FlatAppearance.BorderSize = 0;
            this.checkBU.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkBU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBU.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBU.Location = new System.Drawing.Point(138, 0);
            this.checkBU.Margin = new System.Windows.Forms.Padding(0);
            this.checkBU.Name = "checkBU";
            this.checkBU.Size = new System.Drawing.Size(46, 50);
            this.checkBU.TabIndex = 8;
            this.checkBU.Text = "BU";
            this.checkBU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBU.UseVisualStyleBackColor = true;
            this.checkBU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkStyle_Click);
            // 
            // checkIM
            // 
            this.checkIM.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkIM.FlatAppearance.BorderSize = 0;
            this.checkIM.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkIM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.checkIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkIM.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIM.Location = new System.Drawing.Point(184, 0);
            this.checkIM.Margin = new System.Windows.Forms.Padding(0);
            this.checkIM.Name = "checkIM";
            this.checkIM.Size = new System.Drawing.Size(46, 50);
            this.checkIM.TabIndex = 9;
            this.checkIM.Text = "IM";
            this.checkIM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkIM.UseVisualStyleBackColor = true;
            this.checkIM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkStyle_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel3.Controls.Add(this.check25, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.check50, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.check75, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.check100, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.check200, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.check400, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.check800, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.check1500, 3, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 207);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 100);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // check25
            // 
            this.check25.Appearance = System.Windows.Forms.Appearance.Button;
            this.check25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check25.FlatAppearance.BorderSize = 0;
            this.check25.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check25.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check25.Location = new System.Drawing.Point(0, 0);
            this.check25.Margin = new System.Windows.Forms.Padding(0);
            this.check25.Name = "check25";
            this.check25.Size = new System.Drawing.Size(58, 50);
            this.check25.TabIndex = 14;
            this.check25.Text = "25m";
            this.check25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check25.UseVisualStyleBackColor = true;
            this.check25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check50
            // 
            this.check50.Appearance = System.Windows.Forms.Appearance.Button;
            this.check50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check50.FlatAppearance.BorderSize = 0;
            this.check50.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check50.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check50.Location = new System.Drawing.Point(58, 0);
            this.check50.Margin = new System.Windows.Forms.Padding(0);
            this.check50.Name = "check50";
            this.check50.Size = new System.Drawing.Size(57, 50);
            this.check50.TabIndex = 15;
            this.check50.Text = "50m";
            this.check50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check50.UseVisualStyleBackColor = true;
            this.check50.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check75
            // 
            this.check75.Appearance = System.Windows.Forms.Appearance.Button;
            this.check75.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check75.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check75.FlatAppearance.BorderSize = 0;
            this.check75.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check75.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check75.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check75.Location = new System.Drawing.Point(115, 0);
            this.check75.Margin = new System.Windows.Forms.Padding(0);
            this.check75.Name = "check75";
            this.check75.Size = new System.Drawing.Size(57, 50);
            this.check75.TabIndex = 16;
            this.check75.Text = "75m";
            this.check75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check75.UseVisualStyleBackColor = true;
            this.check75.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check100
            // 
            this.check100.Appearance = System.Windows.Forms.Appearance.Button;
            this.check100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check100.FlatAppearance.BorderSize = 0;
            this.check100.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check100.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check100.Location = new System.Drawing.Point(172, 0);
            this.check100.Margin = new System.Windows.Forms.Padding(0);
            this.check100.Name = "check100";
            this.check100.Size = new System.Drawing.Size(58, 50);
            this.check100.TabIndex = 17;
            this.check100.Text = "100m";
            this.check100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check100.UseVisualStyleBackColor = true;
            this.check100.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check200
            // 
            this.check200.Appearance = System.Windows.Forms.Appearance.Button;
            this.check200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check200.FlatAppearance.BorderSize = 0;
            this.check200.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check200.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check200.Location = new System.Drawing.Point(0, 50);
            this.check200.Margin = new System.Windows.Forms.Padding(0);
            this.check200.Name = "check200";
            this.check200.Size = new System.Drawing.Size(58, 50);
            this.check200.TabIndex = 18;
            this.check200.Text = "200m";
            this.check200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check200.UseVisualStyleBackColor = true;
            this.check200.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check400
            // 
            this.check400.Appearance = System.Windows.Forms.Appearance.Button;
            this.check400.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check400.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check400.FlatAppearance.BorderSize = 0;
            this.check400.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check400.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check400.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check400.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check400.Location = new System.Drawing.Point(58, 50);
            this.check400.Margin = new System.Windows.Forms.Padding(0);
            this.check400.Name = "check400";
            this.check400.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.check400.Size = new System.Drawing.Size(57, 50);
            this.check400.TabIndex = 19;
            this.check400.Text = "400m";
            this.check400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check400.UseVisualStyleBackColor = true;
            this.check400.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check800
            // 
            this.check800.Appearance = System.Windows.Forms.Appearance.Button;
            this.check800.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check800.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check800.FlatAppearance.BorderSize = 0;
            this.check800.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check800.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check800.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check800.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check800.Location = new System.Drawing.Point(115, 50);
            this.check800.Margin = new System.Windows.Forms.Padding(0);
            this.check800.Name = "check800";
            this.check800.Size = new System.Drawing.Size(57, 50);
            this.check800.TabIndex = 20;
            this.check800.Text = "800m";
            this.check800.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check800.UseVisualStyleBackColor = true;
            this.check800.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // check1500
            // 
            this.check1500.Appearance = System.Windows.Forms.Appearance.Button;
            this.check1500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check1500.Dock = System.Windows.Forms.DockStyle.Fill;
            this.check1500.FlatAppearance.BorderSize = 0;
            this.check1500.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check1500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.check1500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check1500.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check1500.Location = new System.Drawing.Point(172, 50);
            this.check1500.Margin = new System.Windows.Forms.Padding(0);
            this.check1500.Name = "check1500";
            this.check1500.Size = new System.Drawing.Size(58, 50);
            this.check1500.TabIndex = 21;
            this.check1500.Text = "1500m";
            this.check1500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check1500.UseVisualStyleBackColor = true;
            this.check1500.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkDistance_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLap, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStop, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnReset, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 310);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(230, 50);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Image = global::Swan.Properties.Resources.play_circle;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 50);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLap.Enabled = false;
            this.btnLap.Image = global::Swan.Properties.Resources.pie_chart_lowop;
            this.btnLap.Location = new System.Drawing.Point(57, 0);
            this.btnLap.Margin = new System.Windows.Forms.Padding(0);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(57, 50);
            this.btnLap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLap.TabIndex = 1;
            this.btnLap.TabStop = false;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::Swan.Properties.Resources.stop_circle_lowop;
            this.btnStop.Location = new System.Drawing.Point(114, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(57, 50);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStop.TabIndex = 2;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Enabled = false;
            this.btnReset.Image = global::Swan.Properties.Resources.rotate_ccw_lowop;
            this.btnReset.Location = new System.Drawing.Point(171, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 50);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnReset.TabIndex = 3;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnClose, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(230, 30);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Swan.Properties.Resources.x_black;
            this.btnClose.Location = new System.Drawing.Point(200, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lapLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.splitLabel, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(10, 91);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(230, 60);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // splitLabel
            // 
            this.splitLabel.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.splitLabel, 2);
            this.splitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitLabel.Location = new System.Drawing.Point(0, 30);
            this.splitLabel.Margin = new System.Windows.Forms.Padding(0);
            this.splitLabel.Name = "splitLabel";
            this.splitLabel.Size = new System.Drawing.Size(230, 30);
            this.splitLabel.TabIndex = 3;
            this.splitLabel.Text = "Split:";
            this.splitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.splitLabel.Click += new System.EventHandler(this.toggleLastLaps);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lapsHeadLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.splitsHeadLabel, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lastLapsLabel, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lastSplitsLabel, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.seperatorLabel, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lastSameEventLabel, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.lastSameEventSplitsLabel, 1, 3);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(10, 43);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(230, 80);
            this.tableLayoutPanel7.TabIndex = 6;
            this.tableLayoutPanel7.Visible = false;
            // 
            // lapsHeadLabel
            // 
            this.lapsHeadLabel.AutoSize = true;
            this.lapsHeadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lapsHeadLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapsHeadLabel.Location = new System.Drawing.Point(0, 0);
            this.lapsHeadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lapsHeadLabel.Name = "lapsHeadLabel";
            this.lapsHeadLabel.Size = new System.Drawing.Size(115, 20);
            this.lapsHeadLabel.TabIndex = 8;
            this.lapsHeadLabel.Text = "Lap:";
            this.lapsHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lapsHeadLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // splitsHeadLabel
            // 
            this.splitsHeadLabel.AutoSize = true;
            this.splitsHeadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitsHeadLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitsHeadLabel.Location = new System.Drawing.Point(115, 0);
            this.splitsHeadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.splitsHeadLabel.Name = "splitsHeadLabel";
            this.splitsHeadLabel.Size = new System.Drawing.Size(115, 20);
            this.splitsHeadLabel.TabIndex = 9;
            this.splitsHeadLabel.Text = "Split:";
            this.splitsHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitsHeadLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // lastLapsLabel
            // 
            this.lastLapsLabel.AutoSize = true;
            this.lastLapsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastLapsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLapsLabel.Location = new System.Drawing.Point(0, 20);
            this.lastLapsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastLapsLabel.Name = "lastLapsLabel";
            this.lastLapsLabel.Size = new System.Drawing.Size(115, 20);
            this.lastLapsLabel.TabIndex = 3;
            this.lastLapsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastLapsLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // lastSplitsLabel
            // 
            this.lastSplitsLabel.AutoSize = true;
            this.lastSplitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastSplitsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSplitsLabel.Location = new System.Drawing.Point(115, 20);
            this.lastSplitsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastSplitsLabel.Name = "lastSplitsLabel";
            this.lastSplitsLabel.Size = new System.Drawing.Size(115, 20);
            this.lastSplitsLabel.TabIndex = 5;
            this.lastSplitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastSplitsLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.seperatorLabel, 2);
            this.seperatorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seperatorLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seperatorLabel.Location = new System.Drawing.Point(0, 40);
            this.seperatorLabel.Margin = new System.Windows.Forms.Padding(0);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(230, 20);
            this.seperatorLabel.TabIndex = 7;
            this.seperatorLabel.Text = "Latest recording:";
            this.seperatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seperatorLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // lastSameEventLabel
            // 
            this.lastSameEventLabel.AutoSize = true;
            this.lastSameEventLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastSameEventLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSameEventLabel.Location = new System.Drawing.Point(0, 60);
            this.lastSameEventLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastSameEventLabel.Name = "lastSameEventLabel";
            this.lastSameEventLabel.Size = new System.Drawing.Size(115, 20);
            this.lastSameEventLabel.TabIndex = 4;
            this.lastSameEventLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastSameEventLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // lastSameEventSplitsLabel
            // 
            this.lastSameEventSplitsLabel.AutoSize = true;
            this.lastSameEventSplitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastSameEventSplitsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSameEventSplitsLabel.Location = new System.Drawing.Point(115, 60);
            this.lastSameEventSplitsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastSameEventSplitsLabel.Name = "lastSameEventSplitsLabel";
            this.lastSameEventSplitsLabel.Size = new System.Drawing.Size(115, 20);
            this.lastSameEventSplitsLabel.TabIndex = 6;
            this.lastSameEventSplitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lastSameEventSplitsLabel.Click += new System.EventHandler(this.toggleFullView);
            // 
            // TileStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 370);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TileStopwatch";
            this.Text = "TileStopwatch";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox btnLap;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lapLabel;
        private System.Windows.Forms.CheckBox checkFR;
        private System.Windows.Forms.CheckBox checkBK;
        private System.Windows.Forms.CheckBox checkBR;
        private System.Windows.Forms.CheckBox checkBU;
        private System.Windows.Forms.CheckBox checkIM;
        private System.Windows.Forms.CheckBox check25;
        private System.Windows.Forms.CheckBox check50;
        private System.Windows.Forms.CheckBox check75;
        private System.Windows.Forms.CheckBox check100;
        private System.Windows.Forms.CheckBox check200;
        private System.Windows.Forms.CheckBox check400;
        private System.Windows.Forms.CheckBox check800;
        private System.Windows.Forms.CheckBox check1500;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lastLapsLabel;
        private System.Windows.Forms.Label lastSameEventLabel;
        private System.Windows.Forms.Label splitLabel;
        private System.Windows.Forms.Label lastSplitsLabel;
        private System.Windows.Forms.Label lastSameEventSplitsLabel;
        private System.Windows.Forms.Label seperatorLabel;
        private System.Windows.Forms.Label lapsHeadLabel;
        private System.Windows.Forms.Label splitsHeadLabel;
    }
}