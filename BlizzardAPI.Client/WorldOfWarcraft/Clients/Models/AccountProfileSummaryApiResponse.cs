using System.Collections.Generic;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class AccountProfileSummaryApiResponse
    {
        public class Self
        {
            public string href { get; set; }
        }

        public class User
        {
            public string href { get; set; }
        }

        public class Profile
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
            public User user { get; set; }
            public Profile profile { get; set; }
        }

        public class Character2
        {
            public string href { get; set; }
        }

        public class ProtectedCharacter
        {
            public string href { get; set; }
        }

        public class Key
        {
            public string href { get; set; }
        }

        public class Realm
        {
            public Key key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class Key2
        {
            public string href { get; set; }
        }

        public class PlayableClass
        {
            public Key2 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Key3
        {
            public string href { get; set; }
        }

        public class PlayableRace
        {
            public Key3 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
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

        public class Character
        {
            public Character2 character { get; set; }
            public ProtectedCharacter protected_character { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public Realm realm { get; set; }
            public PlayableClass playable_class { get; set; }
            public PlayableRace playable_race { get; set; }
            public Gender gender { get; set; }
            public Faction faction { get; set; }
            public int level { get; set; }
        }

        public class WowAccount
        {
            public int id { get; set; }
            public List<Character> characters { get; set; }
        }

        public class Collections
        {
            public string href { get; set; }
        }

        public Links _links { get; set; }
        public int id { get; set; }
        public List<WowAccount> wow_accounts { get; set; }
        public Collections collections { get; set; }
    }
}