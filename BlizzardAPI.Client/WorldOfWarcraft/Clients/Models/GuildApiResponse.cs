namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    public class GuildApiResponse
    {
        public class Self
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
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

        public class Media
        {
            public Key2 key { get; set; }
            public int id { get; set; }
        }

        public class Rgba
        {
            public int r { get; set; }
            public int g { get; set; }
            public int b { get; set; }
            public double a { get; set; }
        }

        public class Color
        {
            public int id { get; set; }
            public Rgba rgba { get; set; }
        }

        public class Emblem
        {
            public int id { get; set; }
            public Media media { get; set; }
            public Color color { get; set; }
        }

        public class Key3
        {
            public string href { get; set; }
        }

        public class Media2
        {
            public Key3 key { get; set; }
            public int id { get; set; }
        }

        public class Rgba2
        {
            public int r { get; set; }
            public int g { get; set; }
            public int b { get; set; }
            public double a { get; set; }
        }

        public class Color2
        {
            public int id { get; set; }
            public Rgba2 rgba { get; set; }
        }

        public class Border
        {
            public int id { get; set; }
            public Media2 media { get; set; }
            public Color2 color { get; set; }
        }

        public class Rgba3
        {
            public int r { get; set; }
            public int g { get; set; }
            public int b { get; set; }
            public double a { get; set; }
        }

        public class Color3
        {
            public int id { get; set; }
            public Rgba3 rgba { get; set; }
        }

        public class Background
        {
            public Color3 color { get; set; }
        }

        public class Crest
        {
            public Emblem emblem { get; set; }
            public Border border { get; set; }
            public Background background { get; set; }
        }

        public class Roster
        {
            public string href { get; set; }
        }

        public class Achievements
        {
            public string href { get; set; }
        }

        public class Activity
        {
            public string href { get; set; }
        }

        public Links _links { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public Faction faction { get; set; }
        public int achievement_points { get; set; }
        public int member_count { get; set; }
        public Realm realm { get; set; }
        public Crest crest { get; set; }
        public Roster roster { get; set; }
        public Achievements achievements { get; set; }
        public long created_timestamp { get; set; }
        public Activity activity { get; set; }
    }
}