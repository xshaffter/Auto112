using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoHitManager
{
    public class Constants
    {

        public static List<string> booleanFields = new()
        {
            "colosseumBronzeCompleted",
            "colosseumSilverCompleted",
            "colosseumGoldCompleted",
            "heartPieceMax",
            "falseKnightDefeated",
            "killedBigBuzzer",
            "hornet1Defeated",
            "defeatedMantisLords",
            "mageLordDefeated",
            "killedMageKnight",
            "killedBigFly",
            "killedInfectedKnight",
            "infectedKnightDreamDefeated",
            "killedDungDefender",
            "mageLordDreamDefeated",
            "killedGhostAladar",
            "killedGhostXero",
            "defeatedMegaBeamMiner",
            "killedMegaBeamMiner",
            "killedMegaMossCharger",
            "killedGhostNoEyes",
            "hornetOutskirtsDefeated",
            "falseKnightDreamDefeated",
            "killedGrimm",
            "killedMawlek",
            "killedGhostHu",
            "monomonDefeated",
            "killedGhostMarmu",
            "killedTraitorLord",
            "killedGhostGalien",
            "killedMimicSpider",
            "killedGhostMarkoth",
            "collectorDefeated",
            "lurienDefeated",
            "whiteDefenderDefeated",
            "killedHiveKnight",
            "killedNightmareGrimm",
            "greyPrinceDefeated",
            "flukeMotherDefeated",
            "killedNailBros",
            "killedPaintmaster",
            "killedNailsage",
            "killedHollowKnightPrime",
            "maskBrokenMonomon",
            "maskBrokenHegemol",
            "maskBrokenLurien",
            "hasShadowDash",
            "hasDash",
            "dreamNailUpgraded",
            "hasDreamNail",
            "hasAcidArmour",
            "hasCyclone",
            "hasDash",
            "hasUpwardSlash",
            "hasDoubleJump",
            "hasShadowDash",
            "hasSuperDash",
            "hasDashSlash",
            "hasWalljump",
            "gotCharm_1",
            "gotCharm_2",
            "gotCharm_3",
            "gotCharm_4",
            "gotCharm_5",
            "gotCharm_6",
            "gotCharm_7",
            "gotCharm_8",
            "gotCharm_9",
            "gotCharm_10",
            "gotCharm_11",
            "gotCharm_12",
            "gotCharm_13",
            "gotCharm_14",
            "gotCharm_15",
            "gotCharm_16",
            "gotCharm_17",
            "gotCharm_18",
            "gotCharm_19",
            "gotCharm_20",
            "gotCharm_21",
            "gotCharm_22",
            "gotCharm_23",
            "gotCharm_24",
            "gotCharm_25",
            "gotCharm_26",
            "gotCharm_27",
            "gotCharm_28",
            "gotCharm_29",
            "gotCharm_30",
            "gotCharm_31",
            "gotCharm_32",
            "gotCharm_33",
            "gotCharm_34",
            "gotCharm_35",
            "gotCharm_36",
            "gotCharm_37",
            "gotCharm_38",
            "gotCharm_39",
            "gotCharm_40",
            "atBench"
        };
        public static List<string> intFields = new()
        {
            "killsFinalBoss",
            "killsMegaBeamMiner",
            "charmSlots",
            "nailDamage",
            "charmsOwned",
            "grubsCollected",
            "fireballLevel",
            "quakeLevel",
            "screamLevel",
        };
        public static readonly string HTML = "<!DOCTYPE html><html><head><title>HitCounterData</title></head><body><script language='javascript'>let run_info = {0};parent.DoUpdate(run_info);</script></body></html>";
        internal static readonly List<string> DreamerZones = new()
        {
            "Dream_Nailcollection",
            "Dream_Guardian_Hegemol",
            "Dream_Guardian_Lurien",
            "Dream_Guardian_Monomon",
            "Dream_Backer_Shrine",
            "Dream_Abyss",
            "Dream_01_False_Knight",
            "Dream_02_Mage_Lord",
            "Dream_03_Infected_Knight",
            "Dream_04_White_Defender",
            "Dream_Room_Believer_Shrine"
        };
        internal static readonly List<string> ProhibitedZones = new()
        {
            "White_Palace"
        };
        private static string folder = "";

        public static string DirFolder
        {
            get
            {
                if (folder == "")
                {
                    var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    var final_dir = Path.Combine(dir, "AutoEssSuperman/");
                    if (!Directory.Exists(final_dir))
                    {
                        Directory.CreateDirectory(final_dir);
                    }
                    folder = final_dir;
                }
                return folder;
            }
        }
    }
}
