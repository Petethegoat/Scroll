namespace Scroll
{
    partial class Scroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scroll));
            this.hideTrayCheck = new System.Windows.Forms.CheckBox();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.captureCheck = new System.Windows.Forms.CheckBox();
            this.scrollCheck = new System.Windows.Forms.CheckBox();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.coords = new System.Windows.Forms.Label();
            this.captureH = new System.Windows.Forms.NumericUpDown();
            this.captureW = new System.Windows.Forms.NumericUpDown();
            this.captureY = new System.Windows.Forms.NumericUpDown();
            this.captureX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // hideTrayCheck
            // 
            this.hideTrayCheck.AutoSize = true;
            this.hideTrayCheck.Location = new System.Drawing.Point(6, 19);
            this.hideTrayCheck.Name = "hideTrayCheck";
            this.hideTrayCheck.Size = new System.Drawing.Size(91, 17);
            this.hideTrayCheck.TabIndex = 0;
            this.hideTrayCheck.Text = "Hide tray icon";
            this.toolTip1.SetToolTip(this.hideTrayCheck, "Hides the tray icon when the program is minimised. When checked, Scroll will mini" +
        "mise on startup.");
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(6, 65);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(91, 17);
            this.adminCheck.TabIndex = 1;
            this.adminCheck.Text = "Run as admin";
            this.toolTip1.SetToolTip(this.adminCheck, "Run Scroll as an administrator.");
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(6, 42);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(96, 17);
            this.startupCheck.TabIndex = 2;
            this.startupCheck.Text = "Run on startup";
            this.toolTip1.SetToolTip(this.startupCheck, "Start Scroll automatically on startup.");
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Fart";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Scroll";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleCaptureToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 70);
            // 
            // toggleCaptureToolStripMenuItem
            // 
            this.toggleCaptureToolStripMenuItem.Name = "toggleCaptureToolStripMenuItem";
            this.toggleCaptureToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toggleCaptureToolStripMenuItem.Text = "Toggle Capture";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // captureCheck
            // 
            this.captureCheck.AutoSize = true;
            this.captureCheck.Location = new System.Drawing.Point(6, 19);
            this.captureCheck.Name = "captureCheck";
            this.captureCheck.Size = new System.Drawing.Size(98, 17);
            this.captureCheck.TabIndex = 0;
            this.captureCheck.Text = "Enable capture";
            this.toolTip1.SetToolTip(this.captureCheck, "Prevent the cursor from leaving the specified area.");
            this.captureCheck.UseVisualStyleBackColor = true;
            // 
            // scrollCheck
            // 
            this.scrollCheck.AutoSize = true;
            this.scrollCheck.Location = new System.Drawing.Point(6, 19);
            this.scrollCheck.Name = "scrollCheck";
            this.scrollCheck.Size = new System.Drawing.Size(100, 17);
            this.scrollCheck.TabIndex = 0;
            this.scrollCheck.Text = "Enable scrolling";
            this.toolTip1.SetToolTip(this.scrollCheck, "Enables scrolling inactive windows during mouse over.");
            this.scrollCheck.UseVisualStyleBackColor = true;
            // 
            // aboutLink
            // 
            this.aboutLink.AutoSize = true;
            this.aboutLink.LinkColor = System.Drawing.Color.Blue;
            this.aboutLink.Location = new System.Drawing.Point(6, 20);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(99, 13);
            this.aboutLink.TabIndex = 1;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "by Pete Goodfellow";
            this.toolTip1.SetToolTip(this.aboutLink, "Visit the Github project page!");
            this.aboutLink.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hideTrayCheck);
            this.groupBox1.Controls.Add(this.adminCheck);
            this.groupBox1.Controls.Add(this.startupCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.coords);
            this.groupBox2.Controls.Add(this.captureH);
            this.groupBox2.Controls.Add(this.captureW);
            this.groupBox2.Controls.Add(this.captureY);
            this.groupBox2.Controls.Add(this.captureX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.captureCheck);
            this.groupBox2.Location = new System.Drawing.Point(145, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursor Capture";
            // 
            // coords
            // 
            this.coords.AutoSize = true;
            this.coords.Location = new System.Drawing.Point(110, 20);
            this.coords.Name = "coords";
            this.coords.Size = new System.Drawing.Size(39, 13);
            this.coords.TabIndex = 13;
            this.coords.Text = "coords";
            // 
            // captureH
            // 
            this.captureH.InterceptArrowKeys = false;
            this.captureH.Location = new System.Drawing.Point(154, 62);
            this.captureH.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.captureH.Minimum = new decimal(new int[] {
            12000,
            0,
            0,
            -2147483648});
            this.captureH.Name = "captureH";
            this.captureH.Size = new System.Drawing.Size(77, 20);
            this.captureH.TabIndex = 12;
            this.captureH.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // captureW
            // 
            this.captureW.InterceptArrowKeys = false;
            this.captureW.Location = new System.Drawing.Point(154, 39);
            this.captureW.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.captureW.Minimum = new decimal(new int[] {
            12000,
            0,
            0,
            -2147483648});
            this.captureW.Name = "captureW";
            this.captureW.Size = new System.Drawing.Size(77, 20);
            this.captureW.TabIndex = 11;
            this.captureW.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // captureY
            // 
            this.captureY.InterceptArrowKeys = false;
            this.captureY.Location = new System.Drawing.Point(27, 62);
            this.captureY.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.captureY.Minimum = new decimal(new int[] {
            12000,
            0,
            0,
            -2147483648});
            this.captureY.Name = "captureY";
            this.captureY.Size = new System.Drawing.Size(77, 20);
            this.captureY.TabIndex = 10;
            // 
            // captureX
            // 
            this.captureX.InterceptArrowKeys = false;
            this.captureX.Location = new System.Drawing.Point(27, 39);
            this.captureX.Maximum = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.captureX.Minimum = new decimal(new int[] {
            12000,
            0,
            0,
            -2147483648});
            this.captureX.Name = "captureX";
            this.captureX.Size = new System.Drawing.Size(77, 20);
            this.captureX.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scrollCheck);
            this.groupBox3.Location = new System.Drawing.Point(145, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 46);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scroll Inactive Windows";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.aboutLink);
            this.groupBox4.Location = new System.Drawing.Point(12, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 46);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scroll 0.4";
            // 
            // Scroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 174);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scroll";
            this.Text = "Scroll";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox hideTrayCheck;
        private System.Windows.Forms.CheckBox adminCheck;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox captureCheck;
        private System.Windows.Forms.NumericUpDown captureH;
        private System.Windows.Forms.NumericUpDown captureW;
        private System.Windows.Forms.NumericUpDown captureY;
        private System.Windows.Forms.NumericUpDown captureX;
        private System.Windows.Forms.Label coords;
        private System.Windows.Forms.ToolStripMenuItem toggleCaptureToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox scrollCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel aboutLink;
    }
}

