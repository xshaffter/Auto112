using AutoHitManager.Cat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoHitManager.Structure
{
    internal class RunData
    {

        private string Colloseum1 => PlayerData.instance.colosseumBronzeCompleted.ToString().ToLower();
        private string Colloseum2 => PlayerData.instance.colosseumSilverCompleted.ToString().ToLower();
        private string Colloseum3 => PlayerData.instance.colosseumGoldCompleted.ToString().ToLower();

        private string fullMasks => PlayerData.instance.heartPieceMax.ToString().ToLower();

        private int Grubs => PlayerData.instance.grubsCollected;
        private const int TotalGrubs = 46;

        private int Charms 
        {
            get
            {
                List<bool> list = new()
                {
                    PlayerData.instance.gotCharm_1,
                    PlayerData.instance.gotCharm_2,
                    PlayerData.instance.gotCharm_3,
                    PlayerData.instance.gotCharm_4,
                    PlayerData.instance.gotCharm_5,
                    PlayerData.instance.gotCharm_6,
                    PlayerData.instance.gotCharm_7,
                    PlayerData.instance.gotCharm_8,
                    PlayerData.instance.gotCharm_9,
                    PlayerData.instance.gotCharm_10,
                    PlayerData.instance.gotCharm_11,
                    PlayerData.instance.gotCharm_12,
                    PlayerData.instance.gotCharm_13,
                    PlayerData.instance.gotCharm_14,
                    PlayerData.instance.gotCharm_15,
                    PlayerData.instance.gotCharm_16,
                    PlayerData.instance.gotCharm_17,
                    PlayerData.instance.gotCharm_18,
                    PlayerData.instance.gotCharm_19,
                    PlayerData.instance.gotCharm_20,
                    PlayerData.instance.gotCharm_21,
                    PlayerData.instance.gotCharm_22,
                    PlayerData.instance.gotCharm_23,
                    PlayerData.instance.gotCharm_24,
                    PlayerData.instance.gotCharm_25,
                    PlayerData.instance.gotCharm_26,
                    PlayerData.instance.gotCharm_27,
                    PlayerData.instance.gotCharm_28,
                    PlayerData.instance.gotCharm_29,
                    PlayerData.instance.gotCharm_30,
                    PlayerData.instance.gotCharm_31,
                    PlayerData.instance.gotCharm_32,
                    PlayerData.instance.gotCharm_33,
                    PlayerData.instance.gotCharm_34,
                    PlayerData.instance.gotCharm_35,
                    PlayerData.instance.gotCharm_36,
                    PlayerData.instance.gotCharm_37,
                    PlayerData.instance.gotCharm_38,
                    PlayerData.instance.gotCharm_39,
                    PlayerData.instance.gotCharm_40,
                };
                return list.Sum(i => i ? 1 : 0);
            }
        }
        private const int TotalCharms = 40;
        private List<Boss> BossList = new()
        {
            new()
            {
                Name = "False Knight",
                Defeated = PlayerData.instance.falseKnightDefeated,
            },
            new()
            {
                Name = "Vengefly King",
                Defeated = PlayerData.instance.killsBigBuzzer <= 1,
            },
            new()
            {
                Name = "Hornet",
                Defeated = PlayerData.instance.hornet1Defeated,
            },
            new()
            {
                Name = "Mantis Lords",
                Defeated = PlayerData.instance.defeatedMantisLords,
            },
            new()
            {
                Name = "Soul Master",
                Defeated = PlayerData.instance.mageLordDefeated,
            },
            new()
            {
                Name = "Gruz Mother",
                Defeated = PlayerData.instance.killedBigFly,
            },

            new()
            {
                Name = "Soul Warrior",
                Defeated = PlayerData.instance.killedMageKnight,
            },
            new()
            {
                Name = "Broken Vessel",
                Defeated = PlayerData.instance.killedInfectedKnight,
            },
            new()
            {
                Name = "Lost Kin",
                Defeated = PlayerData.instance.infectedKnightDreamDefeated,
            },
            new()
            {
                Name = "Dung Defender",
                Defeated = PlayerData.instance.killedDungDefender,
            },
            new()
            {
                Name = "Soul Tyrant",
                Defeated = PlayerData.instance.mageLordDreamDefeated,
            },
            new()
            {
                Name = "Gorb",
                Defeated = PlayerData.instance.killedGhostAladar,
            },

            new()
            {
                Name = "Xero",
                Defeated = PlayerData.instance.killedGhostXero,
            },
            new()
            {
                Name = "Crystal Guardian",
                Defeated = PlayerData.instance.killedMegaBeamMiner
            },
            new()
            {
                Name = "Enraged Guardian",
                Defeated = PlayerData.instance.killsMegaBeamMiner <= 0,
            },
            new()
            {
                Name = "Mega Moss Charger",
                Defeated = PlayerData.instance.killedMegaMossCharger,
            },
            new()
            {
                Name = "No Eyes",
                Defeated = PlayerData.instance.killedGhostNoEyes,
            },
            new()
            {
                Name = "Hornet Sentinel",
                Defeated = PlayerData.instance.hornetOutskirtsDefeated,
            },

            new()
            {
                Name = "Failed Champion",
                Defeated = PlayerData.instance.falseKnightDreamDefeated,
            },
            new()
            {
                Name = "Grimm",
                Defeated = PlayerData.instance.killedGrimm,
            },
            new()
            {
                Name = "Brooding Mawlek",
                Defeated = PlayerData.instance.killedMawlek,
            },
            new()
            {
                Name = "Elder Hu",
                Defeated = PlayerData.instance.killedGhostHu,
            },
            new()
            {
                Name = "Uumuu",
                Defeated = PlayerData.instance.monomonDefeated,
            },
            new()
            {
                Name = "Marmu",
                Defeated = PlayerData.instance.killedGhostMarmu,
            },

            new()
            {
                Name = "Traitor Lord",
                Defeated = PlayerData.instance.killedTraitorLord,
            },
            new()
            {
                Name = "Galien",
                Defeated = PlayerData.instance.killedGhostGalien,
            },
            new()
            {
                Name = "Nosk",
                Defeated = PlayerData.instance.killedMimicSpider,
            },
            new()
            {
                Name = "Markoth",
                Defeated = PlayerData.instance.killedGhostMarkoth,
            },
            new()
            {
                Name = "Watcher Knights",
                Defeated = PlayerData.instance.lurienDefeated,
            },
            new()
            {
                Name = "White Defender",
                Defeated = PlayerData.instance.whiteDefenderDefeated,
            },

            new()
            {
                Name = "Collector",
                Defeated = PlayerData.instance.collectorDefeated,
            },
            new()
            {
                Name = "Hive Knight",
                Defeated = PlayerData.instance.killedHiveKnight,
            },
            new()
            {
                Name = "NKG",
                Defeated = PlayerData.instance.killedNightmareGrimm,
            },
            new()
            {
                Name = "Grey Prince Zote",
                Defeated = PlayerData.instance.greyPrinceDefeated,
            },
            new()
            {
                Name = "Fluke Mother",
                Defeated = PlayerData.instance.flukeMotherDefeated,
            },
            new()
            {
                Name = "Oro & Mato",
                Defeated = PlayerData.instance.killedNailBros,
            },

            new()
            {
                Name = "Sheo",
                Defeated = PlayerData.instance.killedPaintmaster,
            },
            new()
            {
                Name = "Sly",
                Defeated = PlayerData.instance.killedNailsage,
            },
            new()
            {
                Name = "Pure Vessel",
                Defeated = PlayerData.instance.killedHollowKnightPrime,
            },
            new()
            {
                Name = "Radiance",
                Defeated = PlayerData.instance.killsFinalBoss <= 0,
            },
        };
        private int TotalBossCount => BossList.Count;
        private int BossCount => BossList.Count(boss => boss.Defeated);
        private string Bosses
        {
            get
            {
                int pageSize = 6;
                int indexFalse;
                var firstFalse = BossList.Where(boss => !boss.Defeated).FirstOrDefault();
                if (firstFalse != null)
                {
                    indexFalse = BossList.IndexOf(firstFalse);
                }
                else
                {
                    indexFalse = ((int)Math.Floor(BossList.Count / 6.0)) * 6;
                }
                int page = (int)Math.Floor(indexFalse / 6.0);
                int start = page * pageSize;
                int end = start + pageSize - 1;
                if (end > BossList.Count)
                {
                    pageSize = BossList.Count - start;
                }
                var bosses = BossList.GetRange(start, pageSize);
                string result = string.Join(",", bosses.Select(i => i.ToString()).ToArray()).ToLower();
                return $"{{{result}}}";
            }
        }
        private string EquippedCharms => $"[{string.Join(",", PlayerData.instance.equippedCharms.Select(i=> i.ToString()).ToArray())}]";
        private int CharmSlots => PlayerData.instance.charmSlots;
        private int TotalCharmSlots = 11;
        private int NailStatus => (PlayerData.instance.nailDamage - 5) / 4 <= 4 ? (PlayerData.instance.nailDamage - 5) / 4 : 4;
        private string Dreamers => $"[{PlayerData.instance.maskBrokenMonomon.ToString().ToLower()}, {PlayerData.instance.maskBrokenHegemol.ToString().ToLower()}, {PlayerData.instance.maskBrokenLurien.ToString().ToLower()}]";
        private int Hits => Global.LocalSaveData.Hits;
        private string Fury => Global.IntentionalHit.ToString().ToLower();
        public override string ToString()
        {
            string run_info = $"{{hits: {Hits}, fotf: {Fury}, dreamers: {Dreamers}, boss_count:{BossCount}, total_bosses: {TotalBossCount}, bosses: {Bosses}, charm_count: {Charms}, total_charms: {TotalCharms}, grubs: {Grubs}, total_grubs: {TotalGrubs}, masks: {fullMasks}, colosseum1: {Colloseum1}, colosseum2: {Colloseum2}, colosseum3: {Colloseum3}, nail: {NailStatus}, slots: {CharmSlots}, max_slots:{TotalCharmSlots}, charms:{EquippedCharms}, last_update: '{DateTime.Now.ToString("hh:mm:ss")}'}}";
            string html_text = string.Format(Constants.HTML, run_info);
            return html_text;
        }
    }
}
