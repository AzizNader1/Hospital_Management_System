namespace HMS.Domain.Entities
{
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int UserId { get; set; }
        public virtual User Users { get; set; } = new();
    }
}
