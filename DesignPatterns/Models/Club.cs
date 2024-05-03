namespace DesignPatterns.Models
{
    public class Club
    {
        public string Name { get; set; } = string.Empty;

        public DateTime Founded { get; set; }

        public string Owner { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string League { get; set; } = string.Empty;

        public string StadiumName { get; set; } = string.Empty;

        public int StadiumCapacity { get; set; }

        public override string ToString() => $"Club - {Name}, {Founded}, {Owner}";
    }
}
