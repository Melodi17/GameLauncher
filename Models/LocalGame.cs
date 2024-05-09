﻿using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using GameLauncher.Connections;
using GameLauncher.Utils;
using IGDB.Models;

namespace GameLauncher
{
    public class LocalGame
    {
        public readonly string GamePath;

        public string[] LaunchNames => this.LaunchData.Keys.ToArray();
        public Dictionary<string, string> LaunchData;
        public Dictionary<string, string>? GameMetaData;

        public Process? AttachedProcess;
        public bool IsRunning => this.AttachedProcess != null && !this.AttachedProcess.HasExited;

        public string? Name => this.GameMetaData?["name"];
        public string? Genres => this.GameMetaData?["genres"];
        public string? Summary => this.GameMetaData?["summary"];
        public string? CoverUrl => this.GameMetaData?["cover_url"];

        private readonly string resourcePath;
        private readonly string gameMetadataPath;
        private readonly string coverPath;
        private readonly string launchPath;

        public string? CoverPath => this.coverPath;

        public LocalGame(string filePath)
        {
            this.GamePath = filePath;
            this.launchPath = Path.Join(this.GamePath, "launch.dat");
            this.resourcePath = Path.Join(this.GamePath, "gl.resources");
            this.gameMetadataPath = Path.Combine(this.resourcePath, "metadata.dat");
            this.coverPath = Path.Combine(this.resourcePath, "cover.png");

            this.LaunchData = DatFile.Open(this.launchPath);
        }

        public static LocalGame[] GetLocalGames(string scanDir)
        {
            foreach (string file in Directory.GetFiles(scanDir, "HOW TO RUN GAME!!.txt", SearchOption.AllDirectories))
                GenerateLaunchFromHowToLaunch(file);

            return Directory.GetFiles(scanDir, "launch.dat", SearchOption.AllDirectories)
                .Select(x => new LocalGame(Path.GetDirectoryName(x)))
                .ToArray();
        }

        private static void GenerateLaunchFromHowToLaunch(string filePath)
        {
            string dir = Path.GetDirectoryName(filePath);
            string launchFile = Path.Combine(dir, "launch.dat");

            // Do not overwrite if theres already a launch file!!
            if (File.Exists(launchFile))
                return;

            Match m = Regex.Match(File.ReadAllText(filePath), "right click and run '(.*?)' as administrator");
            string file = m.Groups[1].Value + ".exe";

            DatFile.Save(launchFile, new Dictionary<string, string> { { "default", file } });
        }

        public Process Launch(string mode = "default")
        {
            if (!this.LaunchData.ContainsKey(mode))
                throw new RestorableError("Specified launch mode not found");

            string fileName = this.LaunchData[mode];

            string fileExt = Path.GetExtension(fileName.Trim());
            string[] results = Directory.GetFiles(this.GamePath, "*" + fileExt, SearchOption.AllDirectories)
                .Where(x => Path.GetFileName(x) == fileName.Trim()).ToArray();

            if (results.Length != 1)
                throw new RestorableError("No, or multiple results found");

            this.AttachedProcess = Process.Start(results.First());
            return this.AttachedProcess;
        }

        public bool HasResources()
        {
            bool exists = Directory.Exists(this.resourcePath);
            if (exists && Directory.GetFiles(this.resourcePath).Length != 2)
            {
                this.DeleteResources();
                return false;
            }
            return exists;
        }

        public void DeleteResources()
        {
            Directory.Delete(this.resourcePath, true);
        }

        public void LoadOrDownloadResources()
        {
            if (!this.HasResources())
            {
                Game? game = Management.IGDBObj.Search(Path.GetFileNameWithoutExtension(this.GamePath))
                        .FirstOrDefault() ?? throw new Exception("Could not find game in IGDB");

                WebClient client = new();

                Directory.CreateDirectory(this.resourcePath);

                byte[] coverData = client.DownloadData(Management.IGDBObj.ImageUrl(game.Cover.Value, ImageSize.CoverBig));

                this.GameMetaData = new()
                {
                    { "name", game.Name },
                    { "genres", string.Join(", ", game.Genres.Values.Select(x => x.Name)) },
                    { "summary", game.Summary },
                    { "cover_url", Management.IGDBObj.ImageUrl(game.Cover.Value, ImageSize.Thumb) }
                };

                File.WriteAllBytes(this.coverPath, coverData);
                DatFile.Save(this.gameMetadataPath, this.GameMetaData);

            }

            // We set this above, theres no point reloading it.
            // ??= allows modifications only when initial value is null;
            this.GameMetaData ??= DatFile.Open(this.gameMetadataPath);
        }

        public void LoadOrDownloadResourcesAsync(Action callback)
        {
            new Thread(() =>
            {
                this.LoadOrDownloadResources();
                
                callback();
            }).Start();
        }

        public void Kill()
        {
            if (!this.IsRunning)
                throw new RestorableError("Game not running");

            this.AttachedProcess.Kill();
            this.AttachedProcess = null;
        }

        public void ScanForExistingProcess(Process[] processes)
        {
            // Look for processes with the same name
            Process? process = this.LaunchData.Values
                .SelectMany(x => processes.Where(z=> z.ProcessName + ".exe" == x))
                .Where(x => x.GetMainModuleFilepath()?.IsSubPathOf(this.GamePath) ?? false).FirstOrDefault();

            if (process != null)
            {
                this.AttachedProcess = process;
                return;
            }

            // Look for ones in the same dir (can't, its too expensive)
            //process = processes
            //    .Where(x => x.GetMainModuleFilepath()?.IsSubPathOf(GamePath) ?? false).FirstOrDefault();

            //if (process != null) AttachedProcess = process;
        }

        public void Uninstall()
        {
            throw new NotImplementedException();
            // rmdir /S /Q "folder"
        }
    }
}