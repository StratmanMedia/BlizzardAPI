using System.Linq;

namespace BlizzardAPI.Client.WorldOfWarcraft.Shared.Extensions
{
    internal static class ParseHrefForGuildSlugExtension
    {
        internal static string ParseGuildSlug(this string href)
        {
            var parse1 = href.Split('/');
            if (!parse1.Any()) return null;

            var parse2 = parse1[^1].Split('?');
            if (!parse2.Any()) return null;

            var slug = parse2[0];
            return slug;
        }
    }
}