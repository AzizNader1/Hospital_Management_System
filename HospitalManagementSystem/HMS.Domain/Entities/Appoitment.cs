using HMS.Domain.Enums;

namespace HMS.Domain.Entities
{
    public class Appoitment
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; } = new DateOnly();
        public TimeOnly Time { get; set; } = new TimeOnly();
        public AppoitmentStatus Status { get; set; } = AppoitmentStatus.Scheduled;

        public int PatientId { get; set; }
        public int SectorId { get; set; }
        public virtual Patient Patient { get; set; } = new();
        public virtual Sector Sector { get; set; } = new();
    }
}
