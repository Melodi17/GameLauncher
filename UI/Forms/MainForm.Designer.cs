namespace GameLauncher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.addManuallyToolStripMenuItem = new ToolStripMenuItem();
            this.purgeAllMetadataToolStripMenuItem = new ToolStripMenuItem();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.LoadingProgressBar = new ProgressBar();
            this.panel1 = new Panel();
            this.flowLayoutPanel2 = new FlowLayoutPanel();
            this.HomeNavLabel = new Label();
            this.DetailNavLabel = new Label();
            this.SettingNavLabel = new Label();
            this.paletteExtenderProvider1 = new Models.PaletteExtenderProvider();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.flowLayoutPanel1.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.Location = new Point(0, 85);
            this.flowLayoutPanel1.Margin = new Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new Size(1554, 1020);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.addManuallyToolStripMenuItem, this.purgeAllMetadataToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(289, 80);
            // 
            // addManuallyToolStripMenuItem
            // 
            this.addManuallyToolStripMenuItem.Name = "addManuallyToolStripMenuItem";
            this.addManuallyToolStripMenuItem.Size = new Size(288, 38);
            this.addManuallyToolStripMenuItem.Text = "Add manually";
            this.addManuallyToolStripMenuItem.Click += this.addManuallyToolStripMenuItem_Click;
            // 
            // purgeAllMetadataToolStripMenuItem
            // 
            this.purgeAllMetadataToolStripMenuItem.Name = "purgeAllMetadataToolStripMenuItem";
            this.purgeAllMetadataToolStripMenuItem.Size = new Size(288, 38);
            this.purgeAllMetadataToolStripMenuItem.Text = "Purge all metadata";
            this.purgeAllMetadataToolStripMenuItem.Click += this.purgeAllMetadataToolStripMenuItem_Click;
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 1000;
            this.TickTimer.Tick += this.TickTimer_Tick;
            // 
            // LoadingProgressBar
            // 
            this.LoadingProgressBar.BackColor = Color.White;
            this.LoadingProgressBar.Dock = DockStyle.Bottom;
            this.LoadingProgressBar.Location = new Point(0, 1105);
            this.LoadingProgressBar.Margin = new Padding(6);
            this.LoadingProgressBar.Name = "LoadingProgressBar";
            this.LoadingProgressBar.Size = new Size(1554, 49);
            this.LoadingProgressBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(47, 51, 58);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1554, 85);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.HomeNavLabel);
            this.flowLayoutPanel2.Controls.Add(this.DetailNavLabel);
            this.flowLayoutPanel2.Controls.Add(this.SettingNavLabel);
            this.flowLayoutPanel2.Dock = DockStyle.Fill;
            this.flowLayoutPanel2.Location = new Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new Padding(10, 17, 0, 0);
            this.flowLayoutPanel2.Size = new Size(1554, 85);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // HomeNavLabel
            // 
            this.HomeNavLabel.AutoSize = true;
            this.HomeNavLabel.Cursor = Cursors.Hand;
            this.HomeNavLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.HomeNavLabel.ForeColor = Color.FromArgb(142, 122, 181);
            this.HomeNavLabel.Location = new Point(30, 17);
            this.HomeNavLabel.Margin = new Padding(20, 0, 20, 0);
            this.HomeNavLabel.Name = "HomeNavLabel";
            this.HomeNavLabel.Size = new Size(107, 45);
            this.HomeNavLabel.TabIndex = 0;
            this.HomeNavLabel.Text = "Home";
            this.HomeNavLabel.Click += this.HomeNavLabel_Click;
            // 
            // DetailNavLabel
            // 
            this.DetailNavLabel.AutoSize = true;
            this.DetailNavLabel.Cursor = Cursors.Hand;
            this.DetailNavLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.DetailNavLabel.Location = new Point(177, 17);
            this.DetailNavLabel.Margin = new Padding(20, 0, 20, 0);
            this.DetailNavLabel.Name = "DetailNavLabel";
            this.DetailNavLabel.Size = new Size(116, 45);
            this.DetailNavLabel.TabIndex = 2;
            this.DetailNavLabel.Text = "Details";
            this.DetailNavLabel.Click += this.DetailNavLabel_Click;
            // 
            // SettingNavLabel
            // 
            this.SettingNavLabel.AutoSize = true;
            this.SettingNavLabel.Cursor = Cursors.Hand;
            this.SettingNavLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.SettingNavLabel.Location = new Point(333, 17);
            this.SettingNavLabel.Margin = new Padding(20, 0, 20, 0);
            this.SettingNavLabel.Name = "SettingNavLabel";
            this.SettingNavLabel.Size = new Size(135, 45);
            this.SettingNavLabel.TabIndex = 1;
            this.SettingNavLabel.Text = "Settings";
            this.SettingNavLabel.Click += this.SettingNavLabel_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(36, 39, 45);
            this.ClientSize = new Size(1554, 1154);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LoadingProgressBar);
            this.Controls.Add(this.panel1);
            this.ForeColor = Color.WhiteSmoke;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Margin = new Padding(6);
            this.MinimumSize = new Size(1580, 1225);
            this.Name = "MainForm";
            this.Text = "Game Launcher";
            this.FormClosed += this.Form1_FormClosed;
            this.Load += this.Form1_Load;
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem purgeAllMetadataToolStripMenuItem;
        private ToolStripMenuItem addManuallyToolStripMenuItem;
        private System.Windows.Forms.Timer TickTimer;
        private ProgressBar LoadingProgressBar;
        private Panel panel1;
        private Label HomeNavLabel;
        private Label SettingNavLabel;
        private Label DetailNavLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Models.PaletteExtenderProvider paletteExtenderProvider1;
    }
}