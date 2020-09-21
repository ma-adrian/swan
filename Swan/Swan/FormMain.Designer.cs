namespace Swan
{
    partial class FormMain
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
            this.panelVertical = new System.Windows.Forms.Panel();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.btnMenuStopwatch = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.check50 = new System.Windows.Forms.CheckBox();
            this.checkTM = new System.Windows.Forms.CheckBox();
            this.btnStartAllStopwatch = new System.Windows.Forms.PictureBox();
            this.btnOkDisabled = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllStopwatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOkDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panelVertical.Controls.Add(this.btnMenuAdd);
            this.panelVertical.Controls.Add(this.btnMenuStopwatch);
            this.panelVertical.Controls.Add(this.logo);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 0);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(240, 650);
            this.panelVertical.TabIndex = 0;
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuAdd.FlatAppearance.BorderSize = 0;
            this.btnMenuAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMenuAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdd.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdd.ForeColor = System.Drawing.Color.White;
            this.btnMenuAdd.Image = global::Swan.Properties.Resources.user_plus_small;
            this.btnMenuAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdd.Location = new System.Drawing.Point(0, 174);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(240, 68);
            this.btnMenuAdd.TabIndex = 1;
            this.btnMenuAdd.Text = "Add Swimmer";
            this.btnMenuAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // btnMenuStopwatch
            // 
            this.btnMenuStopwatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuStopwatch.FlatAppearance.BorderSize = 0;
            this.btnMenuStopwatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMenuStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStopwatch.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuStopwatch.ForeColor = System.Drawing.Color.White;
            this.btnMenuStopwatch.Image = global::Swan.Properties.Resources.clock_small;
            this.btnMenuStopwatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuStopwatch.Location = new System.Drawing.Point(0, 100);
            this.btnMenuStopwatch.Name = "btnMenuStopwatch";
            this.btnMenuStopwatch.Size = new System.Drawing.Size(240, 68);
            this.btnMenuStopwatch.TabIndex = 0;
            this.btnMenuStopwatch.Text = "Stopwatch";
            this.btnMenuStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuStopwatch.UseVisualStyleBackColor = true;
            this.btnMenuStopwatch.Click += new System.EventHandler(this.btnMenuStopwatch_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Swan.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(8, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(128, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.check50);
            this.panelTop.Controls.Add(this.checkTM);
            this.panelTop.Controls.Add(this.btnStartAllStopwatch);
            this.panelTop.Controls.Add(this.btnOkDisabled);
            this.panelTop.Controls.Add(this.btnOk);
            this.panelTop.Controls.Add(this.btnMaximize);
            this.panelTop.Controls.Add(this.btnHide);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnSlide);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(240, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1060, 50);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // check50
            // 
            this.check50.Appearance = System.Windows.Forms.Appearance.Button;
            this.check50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check50.FlatAppearance.BorderSize = 0;
            this.check50.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.check50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.check50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.check50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check50.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check50.ForeColor = System.Drawing.Color.White;
            this.check50.Location = new System.Drawing.Point(165, 6);
            this.check50.Name = "check50";
            this.check50.Size = new System.Drawing.Size(40, 35);
            this.check50.TabIndex = 8;
            this.check50.Text = "25";
            this.check50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.check50.UseVisualStyleBackColor = true;
            this.check50.CheckedChanged += new System.EventHandler(this.check50_CheckedChanged);
            // 
            // checkTM
            // 
            this.checkTM.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTM.FlatAppearance.BorderSize = 0;
            this.checkTM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkTM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkTM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTM.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTM.ForeColor = System.Drawing.Color.White;
            this.checkTM.Location = new System.Drawing.Point(109, 6);
            this.checkTM.Name = "checkTM";
            this.checkTM.Size = new System.Drawing.Size(40, 35);
            this.checkTM.TabIndex = 7;
            this.checkTM.Text = "TR";
            this.checkTM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkTM.UseVisualStyleBackColor = true;
            this.checkTM.CheckedChanged += new System.EventHandler(this.checkTM_CheckedChanged);
            // 
            // btnStartAllStopwatch
            // 
            this.btnStartAllStopwatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAllStopwatch.Image = global::Swan.Properties.Resources.play_circle_white;
            this.btnStartAllStopwatch.Location = new System.Drawing.Point(58, 6);
            this.btnStartAllStopwatch.Name = "btnStartAllStopwatch";
            this.btnStartAllStopwatch.Size = new System.Drawing.Size(35, 35);
            this.btnStartAllStopwatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStartAllStopwatch.TabIndex = 6;
            this.btnStartAllStopwatch.TabStop = false;
            this.btnStartAllStopwatch.Visible = false;
            this.btnStartAllStopwatch.Click += new System.EventHandler(this.btnStartAllStopwatch_Click);
            // 
            // btnOkDisabled
            // 
            this.btnOkDisabled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOkDisabled.Image = global::Swan.Properties.Resources.check_circle_lowop;
            this.btnOkDisabled.Location = new System.Drawing.Point(58, 6);
            this.btnOkDisabled.Name = "btnOkDisabled";
            this.btnOkDisabled.Size = new System.Drawing.Size(35, 35);
            this.btnOkDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOkDisabled.TabIndex = 5;
            this.btnOkDisabled.TabStop = false;
            this.btnOkDisabled.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Image = global::Swan.Properties.Resources.check_circle;
            this.btnOk.Location = new System.Drawing.Point(58, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(35, 35);
            this.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOk.TabIndex = 4;
            this.btnOk.TabStop = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = global::Swan.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(966, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Image = global::Swan.Properties.Resources.minus;
            this.btnHide.Location = new System.Drawing.Point(915, 6);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(35, 35);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHide.TabIndex = 3;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::Swan.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(966, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Visible = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Swan.Properties.Resources.x;
            this.btnClose.Location = new System.Drawing.Point(1017, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Swan.Properties.Resources.menu;
            this.btnSlide.Location = new System.Drawing.Point(7, 6);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(240, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1060, 600);
            this.panelContent.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panelContent);
            this.mainPanel.Controls.Add(this.panelTop);
            this.mainPanel.Controls.Add(this.panelVertical);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1300, 650);
            this.mainPanel.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 470);
            this.Name = "FormMain";
            this.panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllStopwatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOkDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnMenuStopwatch;
        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.PictureBox btnOk;
        private System.Windows.Forms.PictureBox btnOkDisabled;
        private System.Windows.Forms.PictureBox btnStartAllStopwatch;
        private System.Windows.Forms.CheckBox checkTM;
        private System.Windows.Forms.CheckBox check50;
        private System.Windows.Forms.Panel mainPanel;
    }
}