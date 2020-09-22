namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class ProtectedCharacterProfileSummaryApiResponse
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

        public class ProtectedStats
        {
            public int total_number_deaths { get; set; }
            public long total_gold_gained { get; set; }
            public long total_gold_lost { get; set; }
            public int total_item_value_gained { get; set; }
            public int level_number_deaths { get; set; }
            public long level_gold_gained { get; set; }
            public long level_gold_lost { get; set; }
            public int level_item_value_gained { get; set; }
        }

        public class Zone
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Map
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Position
        {
            public Zone zone { get; set; }
            public Map map { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
            public double facing { get; set; }
        }

        public class Zone2
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Map2
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class BindPosition
        {
            public Zone2 zone { get; set; }
            public Map2 map { get; set; }
            public double x { get; set; }
            public double y { get; set; }
            public double z { get; set; }
            public double facing { get; set; }
        }

        public Links _links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public long money { get; set; }
        public Character character { get; set; }
        public ProtectedStats protected_stats { get; set; }
        public Position position { get; set; }
        public BindPosition bind_position { get; set; }
        public int wow_account { get; set; }
    }
}