using System;
using BlizzardAPI.Client.WorldOfWarcraft.Guilds.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Shared.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Characters.Models
{
    public class Character
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Faction Faction { get; set; }
        public Race Race { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Specialization ActiveSpec { get; set; }
        public Realm Realm { get; set; }
        public Guild Guild { get; set; }
        public int Level { get; set; }
        public long Experience { get; set; }
        public int AchievementPoints { get; set; }
        //todo: public Achievement[] Achievements { get; set; }
        //todo: public Title[] Titles { get; set; }
        //todo: public PvpSummary PvpSummary { get; set; }
        //todo: public Encounter[] Encounters { get; set; }
        //todo: public Media Media { get; set; }
        public long LastLoginTimestamp { get; set; }
        public DateTime LastLogin { get; set; }
        public int AverageItemLevel { get; set; }
        public int EquippedItemLevel { get; set; }
        //todo: public Specialization[] Specializations { get; set; }
        //todo: public Statistics Statistics { get; set; }
        //todo: public MythicKeystoneProfile MythicKeystoneProfile { get; set; }
        //todo: public Equipment Equipment { get; set; }
        //todo: public Appearance Appearance { get; set; }
        //todo: public Collection[] Collections { get; set; }
        public Title ActiveTitle { get; set; }
        //todo: public Reputation[] Reputations { get; set; }
        //todo: public Quest[] Quests { get; set; }
        //todo: public AchievementStatistics AchievementStatistics { get; set; }
        //todo: public Profession[] Professions { get; set; }
        public long Money { get; set; }
        public ProtectedStats ProtectedStats { get; set; }
        public Position Position { get; set; }
        public Position BindPosition { get; set; }
        public long WowAccount { get; set; }
    }
}