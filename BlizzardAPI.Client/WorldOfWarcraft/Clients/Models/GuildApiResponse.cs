namespace BlizzardAPI.Client.WorldOfWarcraft.Clients.Models
{
    internal class GuildApiResponse
    {
        internal class Self
        {
            internal string href { get; set; }
        }

        internal class Links
        {
            internal Self self { get; set; }
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

        internal class Media
        {
            internal Key2 key { get; set; }
            internal int id { get; set; }
        }

        internal class Rgba
        {
            internal int r { get; set; }
            internal int g { get; set; }
            internal int b { get; set; }
            internal double a { get; set; }
        }

        internal class Color
        {
            internal int id { get; set; }
            internal Rgba rgba { get; set; }
        }

        internal class Emblem
        {
            internal int id { get; set; }
            internal Media media { get; set; }
            internal Color color { get; set; }
        }

        internal class Key3
        {
            internal string href { get; set; }
        }

        internal class Media2
        {
            internal Key3 key { get; set; }
            internal int id { get; set; }
        }

        internal class Rgba2
        {
            internal int r { get; set; }
            internal int g { get; set; }
            internal int b { get; set; }
            internal double a { get; set; }
        }

        internal class Color2
        {
            internal int id { get; set; }
            internal Rgba2 rgba { get; set; }
        }

        internal class Border
        {
            internal int id { get; set; }
            internal Media2 media { get; set; }
            internal Color2 color { get; set; }
        }

        internal class Rgba3
        {
            internal int r { get; set; }
            internal int g { get; set; }
            internal int b { get; set; }
            internal double a { get; set; }
        }

        internal class Color3
        {
            internal int id { get; set; }
            internal Rgba3 rgba { get; set; }
        }

        internal class Background
        {
            internal Color3 color { get; set; }
        }

        internal class Crest
        {
            internal Emblem emblem { get; set; }
            internal Border border { get; set; }
            internal Background background { get; set; }
        }

        internal class Roster
        {
            internal string href { get; set; }
        }

        internal class Achievements
        {
            internal string href { get; set; }
        }

        internal class Activity
        {
            internal string href { get; set; }
        }

        internal Links _links { get; set; }
        internal int id { get; set; }
        internal string name { get; set; }
        internal Faction faction { get; set; }
        internal int achievement_points { get; set; }
        internal int member_count { get; set; }
        internal Realm realm { get; set; }
        internal Crest crest { get; set; }
        internal Roster roster { get; set; }
        internal Achievements achievements { get; set; }
        internal long created_timestamp { get; set; }
        internal Activity activity { get; set; }
    }
}