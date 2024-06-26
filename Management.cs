﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GameLauncher.Connections;
using IGDB.Models;

namespace GameLauncher
{
    internal static class Management
    {
        public static IGDBObj IGDBObj;
        public static RichPresence RichPresence;

        public static bool Running = true;
        public static bool Online = true;
        
        public static readonly Version Version = Assembly.GetEntryAssembly()!.GetName().Version!;
        public static readonly string VersionString = Version.ToString(3);
        public static readonly string ExecutablePath = Environment.ProcessPath!;
        public static Config Config;
        public static bool IGDBViable => !string.IsNullOrEmpty(Config.IGDBId) && !string.IsNullOrEmpty(Config.IGDBSecret);
    }
}
