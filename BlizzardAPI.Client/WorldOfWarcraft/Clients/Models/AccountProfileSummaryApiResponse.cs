using System.Collections.Generic;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    internal class AccountProfileSummaryApiResponse
    {
        internal class Self
        {
            internal string href { get; set; }
        }

        internal class User
        {
            internal string href { get; set; }
        }

        internal class Profile
        {
            internal string href { get; set; }
        }

        internal class Links
        {
            internal Self self { get; set; }
            internal User user { get; set; }
            internal Profile profile { get; set; }
        }

        internal class Character2
        {
            internal string href { get; set; }
        }

        internal class ProtectedCharacter
        {
            internal string href { get; set; }
        }

        internal class Key
        {
            internal string href { get; set; }
        }

        internal class Realm
        {
            internal Key key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal string slug { get; set; }
        }

        internal class Key2
        {
            internal string href { get; set; }
        }

        internal class PlayableClass
        {
            internal Key2 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
        }

        internal class Key3
        {
            internal string href { get; set; }
        }

        internal class PlayableRace
        {
            internal Key3 key { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
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

        internal class Character
        {
            internal Character2 character { get; set; }
            internal ProtectedCharacter protected_character { get; set; }
            internal string name { get; set; }
            internal int id { get; set; }
            internal Realm realm { get; set; }
            internal PlayableClass playable_class { get; set; }
            internal PlayableRace playable_race { get; set; }
            internal Gender gender { get; set; }
            internal Faction faction { get; set; }
            internal int level { get; set; }
        }

        internal class WowAccount
        {
            internal int id { get; set; }
            internal List<Character> characters { get; set; }
        }

        internal class Collections
        {
            internal string href { get; set; }
        }

        internal Links _links { get; set; }
        internal int id { get; set; }
        internal List<WowAccount> wow_accounts { get; set; }
        internal Collections collections { get; set; }
    }
}