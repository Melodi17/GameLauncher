﻿namespace GameLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(this.components);
            addManuallyToolStripMenuItem = new ToolStripMenuItem();
            purgeAllMetadataToolStripMenuItem = new ToolStripMenuItem();
            LoadingProgressBar = new ProgressBar();
            contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ContextMenuStrip = contextMenuStrip1;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(899, 455);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { addManuallyToolStripMenuItem, purgeAllMetadataToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(174, 48);
            // 
            // addManuallyToolStripMenuItem
            // 
            addManuallyToolStripMenuItem.Name = "addManuallyToolStripMenuItem";
            addManuallyToolStripMenuItem.Size = new Size(173, 22);
            addManuallyToolStripMenuItem.Text = "Add manually";
            addManuallyToolStripMenuItem.Click += this.addManuallyToolStripMenuItem_Click;
            // 
            // purgeAllMetadataToolStripMenuItem
            // 
            purgeAllMetadataToolStripMenuItem.Name = "purgeAllMetadataToolStripMenuItem";
            purgeAllMetadataToolStripMenuItem.Size = new Size(173, 22);
            purgeAllMetadataToolStripMenuItem.Text = "Purge all metadata";
            purgeAllMetadataToolStripMenuItem.Click += this.purgeAllMetadataToolStripMenuItem_Click;
            // 
            // LoadingProgressBar
            // 
            LoadingProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoadingProgressBar.Location = new Point(198, 212);
            LoadingProgressBar.Name = "LoadingProgressBar";
            LoadingProgressBar.Size = new Size(502, 30);
            LoadingProgressBar.TabIndex = 1;
            LoadingProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(899, 455);
            this.Controls.Add(LoadingProgressBar);
            this.Controls.Add(flowLayoutPanel1);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Name = "Form1";
            this.Text = "Game Launcher";
            this.Load += this.Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem purgeAllMetadataToolStripMenuItem;
        private ToolStripMenuItem addManuallyToolStripMenuItem;
        private ProgressBar LoadingProgressBar;
    }
}