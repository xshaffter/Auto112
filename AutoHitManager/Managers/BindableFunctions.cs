using AutoHitManager.Cat;
using AutoHitManager.Structure;
using Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Timers;
using UnityEngine;

namespace AutoHitManager.Managers
{
    public static class BindableFunctions
    {
        internal const int UP = 0;
        internal const int DOWN = 1;
        internal static int CountUp = 0;
        internal static int CountDown = 0;
        internal static void ToggleIntentHit()
        {
            Global.IntentionalHit = true;
            Global.FuryTimer.Start();
        }
        #region Actions
        internal static void FuryStep(int type)
        {
            bool isFuryAvailable = PlayerData.instance.GetInt("health") > 1 && Global.IsFuryEquipped && !Global.IsProhibitedZone && !Global.IntentionalHit;
            if (type == UP && CountUp == CountDown && isFuryAvailable)
            {
                CountUp++;
                Global.FuryGestureTimer.Stop();
                Global.FuryGestureTimer.Start();
            }
            else if (type == DOWN && CountUp > CountDown && isFuryAvailable)
            {
                CountDown++;
                Global.FuryGestureTimer.Stop();
                Global.FuryGestureTimer.Start();
            }

            if (CountDown == 2)
            {
                Global.FuryGestureTimer.Stop();
                ToggleIntentHit();
            }
        }
        #endregion Actions

        #region HookDelegates
        private static void CheckProhibitedZone(string name)
        {

            if (Global.IsProhibitedZone = Constants.ProhibitedZones.Any(zone => name.StartsWith(zone) || name == zone))
            {
                Global.IntentionalHit = false;
            }
        }

        private static void CheckDreamerZone(string name)
        {
            if (Global.IsDreamerZone = Constants.DreamerZones.Any(zone => name.ToLower() == zone.ToLower() || name.ToLower().StartsWith(zone.ToLower())))
            {
                Global.IntentionalHit = false;
            }
        }

        private static void CheckCredits(string name)
        {
            if (name == "End_Credits")
            {
                Global.LocalSaveData.Hits = 0;
            }
        }
        #endregion HookDelegates

        #region HookActions

        [HookFunction(Hook = "BeforeSceneLoadHook")]
        private static string CheckScene(string name)
        {
            if (Global.IntentionalHit)
            {
                Global.IntentionalHit = false;
            }
            CheckProhibitedZone(name);
            CheckDreamerZone(name);
            return name;
        }

        [HookFunction(Hook = "CharmUpdateHook")]
        private static void CheckFuryEquipped(PlayerData data, HeroController _)
        {
            Global.IsFuryEquipped = data.equippedCharm_6;
            if (!Global.IsFuryEquipped)
            {
                Global.IntentionalHit = false;
            }
        }

        [HookFunction(Hook = "SavegameLoadHook")]
        private static void LoadRun(int _)
        {
            StartRun();
        }

        [HookFunction(Hook = "NewGameHook")]
        private static void StartRun()
        {
            Global.UpdateRunDataFile();
        }

        [HookFunction(Hook = "AfterTakeDamageHook")]
        private static int ManageHit(int hazardType, int dmg)
        {

            Global.FuryTimer.Stop();
            if (Global.IntentionalHit && (hazardType == 2 || hazardType == 3))
            {
                Global.FuryTimer.Start();
            }
            else
            {
                Global.PerformHit();
                Global.IntentionalHit = false;
            }
            return dmg;
        }

        [HookFunction(Hook = "SetPlayerIntHook")]
        private static void CheckPlayerHealth(string name, int orig)
        {
            if (Constants.intFields.Contains(name))
            {
                Global.UpdateRunDataFile();
            }
            if (name == "health" && orig == 1 && Global.IntentionalHit)
            {
                Global.IntentionalHit = false;
                Global.FuryTimer.Stop();

            } 
            PlayerData.instance.SetIntInternal(name, orig);
        }

        [HookFunction(Hook = "SetPlayerBoolHook")]
        private static void CheckPlayerBool(string name, bool orig)
        {
            if (Constants.booleanFields.Contains(name))
            {
                Global.UpdateRunDataFile();
            }
            PlayerData.instance.SetBoolInternal(name, orig);
        }

        [HookFunction(Hook = "AfterPlayerDeadHook")]
        private static void CheckDeath()
        {
            Global.LocalSaveData.Hits = 0;
        }

        #endregion HookActions

        #region Utils
        private static void StartHooks()
        {
            var methods = Assembly.GetExecutingAssembly().GetTypes().SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic))
                      .Where(m => m.GetCustomAttributes(typeof(HookFunctionAttribute), false).Any())
                      .ToArray();
            foreach (var method in methods)
            {
                var attr = (HookFunctionAttribute)method.GetCustomAttributes(typeof(HookFunctionAttribute), true)[0];
                var eventHandler = typeof(ModHooks).GetEvent(attr.Hook);
                var action = Delegate.CreateDelegate(eventHandler.EventHandlerType, method);
                attr.Action = action;
                eventHandler.AddEventHandler(ModHooks.Instance, action);
            }
        }

        internal static void EndHooks()
        {
            var methods = Assembly.GetExecutingAssembly().GetTypes().SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic))
                      .Where(m => m.GetCustomAttributes(typeof(HookFunctionAttribute), false).Any())
                      .ToArray();
            foreach (var method in methods)
            {
                var attr = (HookFunctionAttribute)method.GetCustomAttributes(typeof(HookFunctionAttribute), true)[0];
                var eventHandler = typeof(ModHooks).GetEvent(attr.Hook);
                eventHandler.RemoveEventHandler(ModHooks.Instance, attr.Action);
            }
        }

        internal static void StartInit()
        {
            Global.GenerateWidget();
            Global.FuryTimer = new Timer
            {
                AutoReset = false,
                Interval = 20_000
            };
            Global.FuryTimer.Elapsed += (sender, e) =>
            {
                Global.IntentionalHit = false;
            };
            Global.FuryGestureTimer = new Timer
            {
                AutoReset = false,
                Interval = 1_000
            };
            Global.FuryGestureTimer.Elapsed += (sender, e) =>
            {
                CountUp = 0;
                CountDown = 0;
            };

            StartHooks();

            Global.UpdateRunDataFile();

        }
        #endregion
    }
}
