using System;
using BlizzardAPI.Client.WorldOfWarcraft.Clients.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Guilds.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Shared.Extensions;

namespace BlizzardAPI.Client.WorldOfWarcraft.Characters.Models
{
    public class Character
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Faction { get; set; }
        public string Race { get; set; }
        public PlayableClass PlayableClass { get; set; }
        public Specialization ActiveSpecialization { get; set; }
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

        internal Character(CharacterProfileSummaryApiResponse response)
        {
            Id = response.id;
            Name = response.name;
            Gender = response.gender.type;
            Faction = response.faction.type;
            Race = response.race.name;
            PlayableClass = new PlayableClass
            {
                Id = response.character_class.id,
                Name = response.character_class.name
            };
            ActiveSpecialization = new Specialization
            {
                Id = response.active_spec.id,
                Name = response.active_spec.name
            };
            Realm = new Realm
            {
                Id = response.realm.id,
                Name = response.realm.name,
                Slug = response.realm.slug
            };
            Guild = new Guild
            {
                Id = response.guild.id,
                Name = response.guild.name,
                Slug = response.guild.key.href.ParseGuildSlug(),
                Realm = new Realm
                {
                    Id = response.guild.realm.id,
                    Name = response.guild.realm.name,
                    Slug = response.guild.realm.slug
                },
                Faction = response.faction.type
            };
            Level = response.level;
            Experience = response.experience;
            AchievementPoints = response.achievement_points;
            LastLoginTimestamp = response.last_login_timestamp;
            AverageItemLevel = response.average_item_level;
            EquippedItemLevel = response.equipped_item_level;
            ActiveTitle = new Title
            {
                Id = response.active_title.id,
                Name = response.active_title.name,
                DisplayString = response.active_title.display_string
            };
        }

        internal Character(AccountProfileSummaryApiResponse.Character response)
        {
            Id = response.id;
            Name = response.name;
            Realm = new Realm
            {
                Id = response.realm.id,
                Name = response.realm.name,
                Slug = response.realm.slug
            };
            PlayableClass = new PlayableClass
            {
                Id = response.playable_class.id,
                Name = response.playable_class.name
            };
            Race = response.playable_race.name;
            Gender = response.gender.type;
            Faction = response.faction.type;
            Level = response.level;
        }
    }
}