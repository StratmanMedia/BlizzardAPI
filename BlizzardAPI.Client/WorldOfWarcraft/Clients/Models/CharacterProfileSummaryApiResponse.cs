namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class CharacterProfileSummaryApiResponse
    {
        public class Self
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
        }

        public class Gender
        {
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Faction
        {
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Key
        {
            public string href { get; set; }
        }

        public class Race
        {
            public Key key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Key2
        {
            public string href { get; set; }
        }

        public class CharacterClass
        {
            public Key2 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Key3
        {
            public string href { get; set; }
        }

        public class ActiveSpec
        {
            public Key3 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Key4
        {
            public string href { get; set; }
        }

        public class Realm
        {
            public Key4 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class Key5
        {
            public string href { get; set; }
        }

        public class Key6
        {
            public string href { get; set; }
        }

        public class Realm2
        {
            public Key6 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class Faction2
        {
            public string type { get; set; }
            public string name { get; set; }
        }

        public class Guild
        {
            public Key5 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public Realm2 realm { get; set; }
            public Faction2 faction { get; set; }
        }

        public class Achievements
        {
            public string href { get; set; }
        }

        public class Titles
        {
            public string href { get; set; }
        }

        public class PvpSummary
        {
            public string href { get; set; }
        }

        public class Encounters
        {
            public string href { get; set; }
        }

        public class Media
        {
            public string href { get; set; }
        }

        public class Specializations
        {
            public string href { get; set; }
        }

        public class Statistics
        {
            public string href { get; set; }
        }

        public class MythicKeystoneProfile
        {
            public string href { get; set; }
        }

        public class Equipment
        {
            public string href { get; set; }
        }

        public class Appearance
        {
            public string href { get; set; }
        }

        public class Collections
        {
            public string href { get; set; }
        }

        public class Key7
        {
            public string href { get; set; }
        }

        public class ActiveTitle
        {
            public Key7 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string display_string { get; set; }
        }

        public class Reputations
        {
            public string href { get; set; }
        }

        public class Quests
        {
            public string href { get; set; }
        }

        public class AchievementsStatistics
        {
            public string href { get; set; }
        }

        public class Professions
        {
            public string href { get; set; }
        }

        public Links _links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Gender gender { get; set; }
        public Faction faction { get; set; }
        public Race race { get; set; }
        public CharacterClass character_class { get; set; }
        public ActiveSpec active_spec { get; set; }
        public Realm realm { get; set; }
        public Guild guild { get; set; }
        public int level { get; set; }
        public int experience { get; set; }
        public int achievement_points { get; set; }
        public Achievements achievements { get; set; }
        public Titles titles { get; set; }
        public PvpSummary pvp_summary { get; set; }
        public Encounters encounters { get; set; }
        public Media media { get; set; }
        public long last_login_timestamp { get; set; }
        public int average_item_level { get; set; }
        public int equipped_item_level { get; set; }
        public Specializations specializations { get; set; }
        public Statistics statistics { get; set; }
        public MythicKeystoneProfile mythic_keystone_profile { get; set; }
        public Equipment equipment { get; set; }
        public Appearance appearance { get; set; }
        public Collections collections { get; set; }
        public ActiveTitle active_title { get; set; }
        public Reputations reputations { get; set; }
        public Quests quests { get; set; }
        public AchievementsStatistics achievements_statistics { get; set; }
        public Professions professions { get; set; }
    }
}