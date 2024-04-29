namespace DesignPatterns.Models
{
    public class Club
    {
        public string? Name { get; set; }

        public DateTime? FoundedDate { get; set; }

        public string? Owner { get; set; }

        public override string ToString() => $"Club - {Name}, {FoundedDate}, {Owner}";
    }
}
