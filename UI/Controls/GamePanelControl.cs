﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLauncher.Utils;
using IGDB.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameLauncher
{
    public partial class GamePanelControl : UserControl, ITick
    {
        private Form1 originForm;
        private LocalGame game;
        private bool stillLoading = true;
        public GamePanelControl(Form1 originForm, LocalGame game)
        {
            this.originForm = originForm;
            this.game = game;
            this.InitializeComponent();
        }

        private void GamePanelControl_Load(object sender, EventArgs e)
        {
            // Fixes transparency issues
            this.NameLabel.Parent = this.CoverImageBox;
            this.MoreButton.Parent = this.CoverImageBox;
            this.PlayButton.Parent = this.CoverImageBox;

            this.game.LoadOrDownloadResourcesAsync(() =>
            {
                this.stillLoading = false;

                this.Invoke(() =>
                {
                    this.UpdateStartButton();
                    this.CoverImageBox.ImageLocation = this.game.CoverPath;

                    this.originForm.TaskCompleted();
                });
            });

            this.UpdateStartButton();
        }

        private void All_MouseLeave(object sender, EventArgs e)
        {
            this.UpdatePos();
        }

        private void All_MouseEnter(object sender, EventArgs e)
        {
            this.UpdatePos();
        }

        public void UpdatePos()
        {
            if (this.stillLoading) return;

            bool inside = this.MouseIsOverControl(this);
            this.PlayButton.Visible = inside;
            this.MoreButton.Visible = inside;
        }

        private bool MouseIsOverControl(Control ctrl) => ctrl.ClientRectangle.Contains(ctrl.PointToClient(Cursor.Position));

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!this.game.IsRunning) this.game.Launch();

            this.UpdateStartButton();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            if (this.stillLoading) return;

            new GameDetailsControl(this.game).Spawn(this.ParentForm!);
        }

        private void UpdateStartButton()
        {
            this.PlayButton.Text = this.game.IsRunning ? "Running" : "Play";
            this.PlayButton.ForeColor = this.game.IsRunning ? Color.Green : Color.Black;
            this.PlayButton.Enabled = !this.game.IsRunning;
            if (this.stillLoading) this.PlayButton.Enabled = false;
        }
        public void Tick() => this.UpdateStartButton();
    }
}