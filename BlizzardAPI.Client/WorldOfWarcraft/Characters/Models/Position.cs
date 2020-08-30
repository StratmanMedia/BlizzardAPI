namespace BlizzardAPI.Client.WorldOfWarcraft.Characters.Models
{
    public class Position
    {
        public Zone Zone { get; set; }
        public Map Map { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public decimal Facing { get; set; }
    }
}