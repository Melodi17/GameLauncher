﻿namespace GameLauncher
{
    partial class GameDetailsControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDetailsControl));
            ThumnailImageBox = new PictureBox();
            TitleLabel = new Label();
            DescriptionLabel = new Label();
            PlayButton = new Button();
            ExpandButton = new Button();
            MoreMenuStrip = new ContextMenuStrip(this.components);
            playToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            uninstallToolStripMenuItem = new ToolStripMenuItem();
            refreshMetadataToolStripMenuItem = new ToolStripMenuItem();
            openInExplorerToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ThumnailImageBox).BeginInit();
            MoreMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThumnailImageBox
            // 
            ThumnailImageBox.Location = new Point(24, 22);
            ThumnailImageBox.Name = "ThumnailImageBox";
            ThumnailImageBox.Size = new Size(132, 176);
            ThumnailImageBox.TabIndex = 0;
            ThumnailImageBox.TabStop = false;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(162, 48);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(402, 48);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "label1";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.Location = new Point(162, 96);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(402, 56);
            DescriptionLabel.TabIndex = 2;
            DescriptionLabel.Text = "label2";
            // 
            // PlayButton
            // 
            PlayButton.Location = new Point(162, 155);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(124, 32);
            PlayButton.TabIndex = 3;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            // 
            // ExpandButton
            // 
            ExpandButton.BackgroundImage = (Image)resources.GetObject("ExpandButton.BackgroundImage");
            ExpandButton.BackgroundImageLayout = ImageLayout.Zoom;
            ExpandButton.Location = new Point(292, 155);
            ExpandButton.Name = "ExpandButton";
            ExpandButton.Size = new Size(27, 32);
            ExpandButton.TabIndex = 4;
            ExpandButton.UseVisualStyleBackColor = true;
            // 
            // MoreMenuStrip
            // 
            MoreMenuStrip.Items.AddRange(new ToolStripItem[] { playToolStripMenuItem, manageToolStripMenuItem });
            MoreMenuStrip.Name = "contextMenuStrip1";
            MoreMenuStrip.Size = new Size(181, 70);
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(180, 22);
            playToolStripMenuItem.Text = "Play";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uninstallToolStripMenuItem, refreshMetadataToolStripMenuItem, openInExplorerToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(180, 22);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // uninstallToolStripMenuItem
            // 
            uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            uninstallToolStripMenuItem.Size = new Size(166, 22);
            uninstallToolStripMenuItem.Text = "Uninstall";
            // 
            // refreshMetadataToolStripMenuItem
            // 
            refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem";
            refreshMetadataToolStripMenuItem.Size = new Size(166, 22);
            refreshMetadataToolStripMenuItem.Text = "Refresh metadata";
            // 
            // openInExplorerToolStripMenuItem
            // 
            openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            openInExplorerToolStripMenuItem.Size = new Size(166, 22);
            openInExplorerToolStripMenuItem.Text = "Open in explorer";
            // 
            // GameDetailsControl
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(ExpandButton);
            this.Controls.Add(PlayButton);
            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(TitleLabel);
            this.Controls.Add(ThumnailImageBox);
            this.Name = "GameDetailsControl";
            this.Size = new Size(588, 331);
            ((System.ComponentModel.ISupportInitialize)ThumnailImageBox).EndInit();
            MoreMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox ThumnailImageBox;
        private Label TitleLabel;
        private Label DescriptionLabel;
        private Button PlayButton;
        private Button ExpandButton;
        private ContextMenuStrip MoreMenuStrip;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem uninstallToolStripMenuItem;
        private ToolStripMenuItem refreshMetadataToolStripMenuItem;
        private ToolStripMenuItem openInExplorerToolStripMenuItem;
    }
}