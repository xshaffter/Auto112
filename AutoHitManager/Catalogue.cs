using AutoHitManager.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoHitManager
{
    internal class BossCat
    {
        internal Boss FalseKnight => new Boss()
        {
            Name = "False Knight",
            Defeated = PlayerData.instance.falseKnightDefeated,
        };
        internal Boss Vengefly => new Boss()
        {
            Name = "Vengefly King",
            Defeated = PlayerData.instance.killsBigBuzzer <= 1,
        };
        internal Boss Hornet => new Boss()
        {
            Name = "Hornet",
            Defeated = PlayerData.instance.hornet1Defeated,
        };
        internal Boss Mantis => new Boss()
        {
            Name = "Mantis Lords",
            Defeated = PlayerData.instance.defeatedMantisLords,
        };
        internal Boss SoulMaster => new Boss()
        {
            Name = "Soul Master",
            Defeated = PlayerData.instance.mageLordDefeated,
        };
        internal Boss Gruz => new Boss()
        {
            Name = "Gruz Mother",
            Defeated = PlayerData.instance.killedBigFly,
        };

        internal Boss SoulWarrior => new Boss()
        {
            Name = "Soul Warrior",
            Defeated = PlayerData.instance.killedMageKnight,
        };
        internal Boss BrokenVessel => new Boss()
        {
            Name = "Broken Vessel",
            Defeated = PlayerData.instance.killedInfectedKnight,
        };
        internal Boss LostKin => new Boss()
        {
            Name = "Lost Kin",
            Defeated = PlayerData.instance.infectedKnightDreamDefeated,
        };
        internal Boss DungDefender => new Boss()
        {
            Name = "Dung Defender",
            Defeated = PlayerData.instance.killedDungDefender,
        };
        internal Boss SoulTyrant => new Boss()
        {
            Name = "Soul Tyrant",
            Defeated = PlayerData.instance.mageLordDreamDefeated,
        };
        internal Boss Gorb => new Boss()
        {
            Name = "Gorb",
            Defeated = PlayerData.instance.killedGhostAladar,
        };

        internal Boss Xero => new Boss()
        {
            Name = "Xero",
            Defeated = PlayerData.instance.killedGhostXero,
        };
        internal Boss CrystalGuardian => new Boss()
        {
            Name = "Crystal Guardian",
            Defeated = PlayerData.instance.killedMegaBeamMiner
        };
        internal Boss EnragedGuardian => new Boss()
        {
            Name = "Enraged Guardian",
            Defeated = PlayerData.instance.killsMegaBeamMiner <= 0,
        };
        internal Boss MegaMossCharge => new Boss()
        {
            Name = "Mega Moss Charger",
            Defeated = PlayerData.instance.killedMegaMossCharger,
        };
        internal Boss NoEyes => new Boss()
        {
            Name = "No Eyes",
            Defeated = PlayerData.instance.killedGhostNoEyes,
        };
        internal Boss HornetSentinel => new Boss()
        {
            Name = "Hornet Sentinel",
            Defeated = PlayerData.instance.hornetOutskirtsDefeated,
        };

        internal Boss FailedChampion => new Boss()
        {
            Name = "Failed Champion",
            Defeated = PlayerData.instance.falseKnightDreamDefeated,
        };
        internal Boss Grimm => new Boss()
        {
            Name = "Grimm",
            Defeated = PlayerData.instance.killedGrimm,
        };
        internal Boss BroodingMawlek => new Boss()
        {
            Name = "Brooding Mawlek",
            Defeated = PlayerData.instance.killedMawlek,
        };
        internal Boss ElderHu => new Boss()
        {
            Name = "Elder Hu",
            Defeated = PlayerData.instance.killedGhostHu,
        };
        internal Boss Uumuu => new Boss()
        {
            Name = "Uumuu",
            Defeated = PlayerData.instance.monomonDefeated,
        };
        internal Boss Marmu => new Boss()
        {
            Name = "Marmu",
            Defeated = PlayerData.instance.killedGhostMarmu,
        };

        internal Boss TraitorLord => new Boss()
        {
            Name = "Traitor Lord",
            Defeated = PlayerData.instance.killedTraitorLord,
        };
        internal Boss Galien => new Boss()
        {
            Name = "Galien",
            Defeated = PlayerData.instance.killedGhostGalien,
        };
        internal Boss Nosk => new Boss()
        {
            Name = "Nosk",
            Defeated = PlayerData.instance.killedMimicSpider,
        };
        internal Boss Markoth => new Boss()
        {
            Name = "Markoth",
            Defeated = PlayerData.instance.killedGhostMarkoth,
        };
        internal Boss WatcherKnights => new Boss()
        {
            Name = "Watcher Knights",
            Defeated = PlayerData.instance.lurienDefeated,
        };
        internal Boss WhiteDefender => new Boss()
        {
            Name = "White Defender",
            Defeated = PlayerData.instance.whiteDefenderDefeated,
        };

        internal Boss Collector => new Boss()
        {
            Name = "Collector",
            Defeated = PlayerData.instance.collectorDefeated,
        };
        internal Boss HiveKnight => new Boss()
        {
            Name = "Hive Knight",
            Defeated = PlayerData.instance.killedHiveKnight,
        };
        internal Boss NKG => new Boss()
        {
            Name = "NKG",
            Defeated = PlayerData.instance.killedNightmareGrimm,
        };
        internal Boss GPZote => new Boss()
        {
            Name = "Grey Prince Zote",
            Defeated = PlayerData.instance.greyPrinceDefeated,
        };
        internal Boss FlukeMother => new Boss()
        {
            Name = "Fluke Mother",
            Defeated = PlayerData.instance.flukeMotherDefeated,
        };
        internal Boss OroNMato => new Boss()
        {
            Name = "Oro & Mato",
            Defeated = PlayerData.instance.killedNailBros,
        };

        internal Boss Sheo => new Boss()
        {
            Name = "Sheo",
            Defeated = PlayerData.instance.killedPaintmaster,
        };
        internal Boss Sly => new Boss()
        {
            Name = "Sly",
            Defeated = PlayerData.instance.killedNailsage,
        };
        internal Boss PureVessel => new Boss()
        {
            Name = "Pure Vessel",
            Defeated = PlayerData.instance.killedHollowKnightPrime,
        };
        internal Boss Radiance => new Boss()
        {
            Name = "Radiance",
            Defeated = PlayerData.instance.killsFinalBoss <= 0,
        };
    }
}
