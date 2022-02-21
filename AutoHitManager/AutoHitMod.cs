using System;
using Modding;
using System.Collections.Generic;
using HutongGames.PlayMaker;
using System.IO;
using System.Linq;
using UnityEngine;

using AutoHitManager.Structure;
using System.Reflection;
using InControl;
using AutoHitManager.Cat;
using AutoHitManager.Managers;
using System.Timers;
using Modding.Menu;
using UnityEngine.UI;
using static AutoHitManager.Managers.BindableFunctions;

namespace AutoHitManager
{
    public class AutoHitMod : Mod
    {
        internal static AutoHitMod LoadedInstance { get; set; }

        internal GameObject Game { get; private set; }
        internal HitManagerSaveData saveData = new();
        public override ModSettings SaveSettings { get => saveData; set => saveData = value as HitManagerSaveData; }

        public bool ToggleButtonInsideMenu => true;

        /// <summary>
        /// Gets or sets the save settings of this Mod
        /// </summary>
        public override void Initialize()
        {
            if (LoadedInstance != null) return;
            LoadedInstance = this;
            ModHooks.Instance.ApplicationQuitHook += SaveMySettings;

            Game = new GameObject();
            Game.AddComponent<BehaviourManager>();
            GameObject.DontDestroyOnLoad(Game);
            StartInit();
        }
        private void SaveMySettings()
        {
            SaveGlobalSettings();
            Log("Saved");
        }


        public void Unload()
        {
            EndHooks();
            LoadedInstance = null;
            GameObject.DestroyImmediate(Game);
        }

        public override string GetVersion() => "1.2.0";
    }
}
