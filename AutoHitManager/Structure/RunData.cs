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
            BossCat.FalseKnight,
            BossCat.Hornet,
            BossCat.Gruz,
            BossCat.Mantis,
            BossCat.SoulMaster,
            BossCat.SoulWarrior1st,
            BossCat.Uumuu,
            BossCat.WatcherKnights,
            BossCat.HollowKnight
        };
        private int TotalBossCount => BossList.Count;
        private int BossCount => BossList.Count(boss => boss.Defeated);
        private string Bosses
        {
            get
            {
                int pageSize = 5;
                int indexFalse; 
                var firstFalse = BossList.Where(boss => !boss.Defeated).FirstOrDefault();
                if (firstFalse != null)
                {
                    indexFalse = BossList.IndexOf(firstFalse);
                }
                else
                {
                    indexFalse = ((int)Math.Floor(BossList.Count / ((float)pageSize))) * pageSize;
                }
                int page = (int)Math.Floor(indexFalse / ((float)pageSize));
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
