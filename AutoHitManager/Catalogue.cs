using AutoHitManager.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoHitManager
{
    internal static class BossCat
    {
        internal static Boss FalseKnight => new Boss()
        {
            Name = "False Knight",
            Defeated = PlayerData.instance.falseKnightDefeated,
        };
        internal static Boss Vengefly => new Boss()
        {
            Name = "Vengefly King",
            Defeated = PlayerData.instance.killsBigBuzzer <= 1,
        };
        internal static Boss Hornet => new Boss()
        {
            Name = "Hornet",
            Defeated = PlayerData.instance.hornet1Defeated,
        };
        internal static Boss Mantis => new Boss()
        {
            Name = "Mantis Lords",
            Defeated = PlayerData.instance.defeatedMantisLords,
        };
        internal static Boss SoulMaster => new Boss()
        {
            Name = "Soul Master",
            Defeated = PlayerData.instance.mageLordDefeated,
        };
        internal static Boss Gruz => new Boss()
        {
            Name = "Gruz Mother",
            Defeated = PlayerData.instance.killedBigFly,
        };

        internal static Boss SoulWarrior1st => new Boss()
        {
            Name = "Soul Warrior",
            Defeated = PlayerData.instance.killedMageKnight,
        };

        internal static Boss SoulWarrior2nd => new Boss()
        {
            Name = "Soul Warrior",
            Defeated = PlayerData.instance.killsMageKnight <= 0,
        };
        internal static Boss BrokenVessel => new Boss()
        {
            Name = "Broken Vessel",
            Defeated = PlayerData.instance.killedInfectedKnight,
        };
        internal static Boss LostKin => new Boss()
        {
            Name = "Lost Kin",
            Defeated = PlayerData.instance.infectedKnightDreamDefeated,
        };
        internal static Boss DungDefender => new Boss()
        {
            Name = "Dung Defender",
            Defeated = PlayerData.instance.killedDungDefender,
        };
        internal static Boss SoulTurant => new Boss()
        {
            Name = "Soul Tyrant",
            Defeated = PlayerData.instance.mageLordDreamDefeated,
        };
        internal static Boss Gorb => new Boss()
        {
            Name = "Gorb",
            Defeated = PlayerData.instance.killedGhostAladar,
        };

        internal static Boss Xero => new Boss()
        {
            Name = "Xero",
            Defeated = PlayerData.instance.killedGhostXero,
        };
        internal static Boss CrystalGuardian => new Boss()
        {
            Name = "Crystal Guardian",
            Defeated = PlayerData.instance.killedMegaBeamMiner
        };
        internal static Boss EnragedGuardian => new Boss()
        {
            Name = "Enraged Guardian",
            Defeated = PlayerData.instance.killsMegaBeamMiner <= 0,
        };
        internal static Boss MegaMossCharge => new Boss()
        {
            Name = "Mega Moss Charger",
            Defeated = PlayerData.instance.killedMegaMossCharger,
        };
        internal static Boss NoEyes => new Boss()
        {
            Name = "No Eyes",
            Defeated = PlayerData.instance.killedGhostNoEyes,
        };
        internal static Boss HornetSentinel => new Boss()
        {
            Name = "Hornet Sentinel",
            Defeated = PlayerData.instance.hornetOutskirtsDefeated,
        };

        internal static Boss FailedChampion => new Boss()
        {
            Name = "Failed Champion",
            Defeated = PlayerData.instance.falseKnightDreamDefeated,
        };
        internal static Boss Grimm => new Boss()
        {
            Name = "Grimm",
            Defeated = PlayerData.instance.killedGrimm,
        };
        internal static Boss BroodingMawlek => new Boss()
        {
            Name = "Brooding Mawlek",
            Defeated = PlayerData.instance.killedMawlek,
        };
        internal static Boss ElderHu => new Boss()
        {
            Name = "Elder Hu",
            Defeated = PlayerData.instance.killedGhostHu,
        };
        internal static Boss Uumuu => new Boss()
        {
            Name = "Uumuu",
            Defeated = PlayerData.instance.monomonDefeated,
        };
        internal static Boss Marmu => new Boss()
        {
            Name = "Marmu",
            Defeated = PlayerData.instance.killedGhostMarmu,
        };

        internal static Boss TraitorsLord => new Boss()
        {
            Name = "Traitor Lord",
            Defeated = PlayerData.instance.killedTraitorLord,
        };
        internal static Boss Galien => new Boss()
        {
            Name = "Galien",
            Defeated = PlayerData.instance.killedGhostGalien,
        };
        internal static Boss Nosk => new Boss()
        {
            Name = "Nosk",
            Defeated = PlayerData.instance.killedMimicSpider,
        };
        internal static Boss Markoth => new Boss()
        {
            Name = "Markoth",
            Defeated = PlayerData.instance.killedGhostMarkoth,
        };
        internal static Boss WatcherKnights => new Boss()
        {
            Name = "Watcher Knights",
            Defeated = PlayerData.instance.lurienDefeated,
        };
        internal static Boss WhiteDefender => new Boss()
        {
            Name = "White Defender",
            Defeated = PlayerData.instance.whiteDefenderDefeated,
        };

        internal static Boss Collector => new Boss()
        {
            Name = "Collector",
            Defeated = PlayerData.instance.collectorDefeated,
        };
        internal static Boss HiveKnight => new Boss()
        {
            Name = "Hive Knight",
            Defeated = PlayerData.instance.killedHiveKnight,
        };
        internal static Boss NKG => new Boss()
        {
            Name = "NKG",
            Defeated = PlayerData.instance.killedNightmareGrimm,
        };
        internal static Boss GPZote => new Boss()
        {
            Name = "Grey Prince Zote",
            Defeated = PlayerData.instance.greyPrinceDefeated,
        };
        internal static Boss FlukeMother => new Boss()
        {
            Name = "Fluke Mother",
            Defeated = PlayerData.instance.flukeMotherDefeated,
        };
        internal static Boss OroNMato => new Boss()
        {
            Name = "Oro & Mato",
            Defeated = PlayerData.instance.killedNailBros,
        };

        internal static Boss Sheo => new Boss()
        {
            Name = "Sheo",
            Defeated = PlayerData.instance.killedPaintmaster,
        };
        internal static Boss Sly => new Boss()
        {
            Name = "Sly",
            Defeated = PlayerData.instance.killedNailsage,
        };
        internal static Boss PureVessel => new Boss()
        {
            Name = "Pure Vessel",
            Defeated = PlayerData.instance.killedHollowKnightPrime,
        };
        internal static Boss Radiance => new Boss()
        {
            Name = "Radiance",
            Defeated = PlayerData.instance.killsFinalBoss <= 0,
        };
        internal static Boss HollowKnight => new Boss()
        {
            Name = "Hollow knight",
            Defeated = PlayerData.instance.killedHollowKnight,
        };
    }
}
