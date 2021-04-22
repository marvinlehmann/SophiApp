﻿using System;
using System.Reflection;

namespace SophiApp.Helpers
{
    internal class AppData
    {
        public static string Name { get => "SophiApp"; }

        public static Version Version { get => Assembly.GetExecutingAssembly().GetName().Version; }

        public static string VersionString { get => Version.ToString().Substring(0, 5); }
    }
}