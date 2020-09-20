namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    internal class CharacterProfileSummaryApiResponse
    {
        internal class Self
        {
            internal string href { get; set; }
        }

        internal class Links
        {
            internal Self self { get; set; }
        }

        internal class Gender
        {
            internal string type { get; set; }
            internal string name { get; set; }
        }

        internal class Faction
        {
            internal string type { get; set; }
            internal string name { get; set; }
        }

        internal class Key
        {
            internal string href { get; set; }
        }

        internal class Race
        {
            internal Key key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
        }

        internal class Key2
        {
            internal string href { get; set; }
        }

        internal class CharacterClass
        {
            internal Key2 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
        }

        internal class Key3
        {
            internal string href { get; set; }
        }

        internal class ActiveSpec
        {
            internal Key3 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
        }

        internal class Key4
        {
            internal string href { get; set; }
        }

        internal class Realm
        {
            internal Key4 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal string slug { get; set; }
        }

        internal class Key5
        {
            internal string href { get; set; }
        }

        internal class Key6
        {
            internal string href { get; set; }
        }

        internal class Realm2
        {
            internal Key6 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal string slug { get; set; }
        }

        internal class Faction2
        {
            internal string type { get; set; }
            internal string name { get; set; }
        }

        internal class Guild
        {
            internal Key5 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal Realm2 realm { get; set; }
            internal Faction2 faction { get; set; }
        }

        internal class Achievements
        {
            internal string href { get; set; }
        }

        internal class Titles
        {
            internal string href { get; set; }
        }

        internal class PvpSummary
        {
            internal string href { get; set; }
        }

        internal class Encounters
        {
            internal string href { get; set; }
        }

        internal class Media
        {
            internal string href { get; set; }
        }

        internal class Specializations
        {
            internal string href { get; set; }
        }

        internal class Statistics
        {
            internal string href { get; set; }
        }

        internal class MythicKeystoneProfile
        {
            internal string href { get; set; }
        }

        internal class Equipment
        {
            internal string href { get; set; }
        }

        internal class Appearance
        {
            internal string href { get; set; }
        }

        internal class Collections
        {
            internal string href { get; set; }
        }

        internal class Key7
        {
            internal string href { get; set; }
        }

        internal class ActiveTitle
        {
            internal Key7 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal string display_string { get; set; }
        }

        internal class Reputations
        {
            internal string href { get; set; }
        }

        internal class Quests
        {
            internal string href { get; set; }
        }

        internal class AchievementsStatistics
        {
            internal string href { get; set; }
        }

        internal class Professions
        {
            internal string href { get; set; }
        }

        internal Links _links { get; set; }
        internal int id { get; set; }
        internal string name { get; set; }
        internal Gender gender { get; set; }
        internal Faction faction { get; set; }
        internal Race race { get; set; }
        internal CharacterClass character_class { get; set; }
        internal ActiveSpec active_spec { get; set; }
        internal Realm realm { get; set; }
        internal Guild guild { get; set; }
        internal int level { get; set; }
        internal int experience { get; set; }
        internal int achievement_points { get; set; }
        internal Achievements achievements { get; set; }
        internal Titles titles { get; set; }
        internal PvpSummary pvp_summary { get; set; }
        internal Encounters encounters { get; set; }
        internal Media media { get; set; }
        internal long last_login_timestamp { get; set; }
        internal int average_item_level { get; set; }
        internal int equipped_item_level { get; set; }
        internal Specializations specializations { get; set; }
        internal Statistics statistics { get; set; }
        internal MythicKeystoneProfile mythic_keystone_profile { get; set; }
        internal Equipment equipment { get; set; }
        internal Appearance appearance { get; set; }
        internal Collections collections { get; set; }
        internal ActiveTitle active_title { get; set; }
        internal Reputations reputations { get; set; }
        internal Quests quests { get; set; }
        internal AchievementsStatistics achievements_statistics { get; set; }
        internal Professions professions { get; set; }
    }
}