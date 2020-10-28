using System.Collections.Generic;

namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class CharacterMediaApiReponse
    {
        public class Self
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
        }

        public class Key
        {
            public string href { get; set; }
        }

        public class Key2
        {
            public string href { get; set; }
        }

        public class Realm
        {
            public Key2 key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public string slug { get; set; }
        }

        public class Character
        {
            public Key key { get; set; }
            public string name { get; set; }
            public int id { get; set; }
            public Realm realm { get; set; }
        }

        public class Asset
        {
            public string key { get; set; }
            public string value { get; set; }
        }

        public Links _links { get; set; }
        public Character character { get; set; }
        public List<Asset> assets { get; set; }
        public string avatar_url { get; set; }
        public string bust_url { get; set; }
        public string render_url { get; set; }
    }
}