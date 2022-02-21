using AutoHitManager.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using KeyValuePair = System.Collections.Generic.Dictionary<string, int>;
using AutoHitManager.Managers;
using System.Timers;
using UnityEngine;

namespace AutoHitManager.Cat
{
    public static class Global
    {
        internal static double FuryTime { get; set; }
        private static bool fury = false;
        internal static bool IsFuryEquipped;
        internal static HitManagerSaveData LocalSaveData => AutoHitMod.LoadedInstance.saveData;
        internal static Timer FuryTimer;
        internal static Timer FuryGestureTimer;
        internal static bool IsProhibitedZone = false;
        internal static SkillsData skillsData = new SkillsData();

        public static bool IntentionalHit
        {
            get
            {
                return fury;
            }
            set
            {
                fury = value;
                BindableFunctions.CountDown = 0;
                BindableFunctions.CountUp = 0;
                UpdateRunDataFile();
            }
        }

        public static void GenerateWidget()
        {
            foreach (var path in GetAllAssemblyFiles())
            {
                string filePath, fileName;
                var slices = path.ReplaceLast(".", "").Split('.').ToList();
                slices.RemoveAt(slices.Count() - 1);
                filePath = string.Join(".", slices.ToArray());
                fileName = path.Replace(filePath + ".", "");
                CopyFileTo(filePath, fileName, Constants.DirFolder);
            }
        }
        private static string[] GetAllAssemblyFiles()
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            string folderName = string.Format("{0}.Resources.", executingAssembly.GetName().Name);
            return executingAssembly
                .GetManifestResourceNames()
                .Where(r => r.StartsWith(folderName) && (r.EndsWith(".html") || r.EndsWith(".js") || r.EndsWith(".css") || r.EndsWith(".png")))
                .ToArray();
        }
        public static string ReplaceLast(this string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[256 * 1024]; // Fairly arbitrary size
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }

        private static void CopyFileTo(string origFolder, string origFile, string dirFolder, bool alwaysCopy = false)
        {
            origFolder = origFolder.Replace("AutoHitManager.Resources.", "");
            origFolder = origFolder.Replace("AutoHitManager.Resources", "");
            if (origFolder != "")
            {
                origFolder += ".";
            }
            var origAsFolder = origFolder.Replace(".", "/");
            var folder = Path.Combine(dirFolder, origAsFolder);
            var path_result = Path.Combine(folder, origFile);
            Directory.CreateDirectory(folder);
            if (alwaysCopy || !File.Exists(path_result))
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"AutoHitManager.Resources.{origFolder}{origFile}");
                var file = File.Create(path_result);
                stream.CopyTo(file);
            }
        }

        public static void UpdateRunDataFile()
        {
            File.WriteAllText(Path.Combine(Constants.DirFolder, "run_data.html"), new RunData().ToString());
        }

        public static void PerformHit()
        {
            LocalSaveData.Hits++;
            UpdateRunDataFile();
        }

        public static void Log(string text)
        {
            AutoHitMod.LoadedInstance.Log(text);
        }

        public static void Log(object text)
        {
            AutoHitMod.LoadedInstance.Log(text);
        }

        public static int RunDetail = 0;
        internal static string PracticeMode = "No";
        internal static int HistoryId;
        internal static bool IsDreamerZone = false;
    }
}
