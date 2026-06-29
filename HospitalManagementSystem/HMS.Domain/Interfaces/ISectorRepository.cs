using HMS.Domain.Entities;

namespace HMS.Domain.Interfaces
{
    public interface ISectorRepository
    {
        Task<Sector?> GetSectorByIdAsync(int id);
        Task<Sector?> GetSectorByNameAsync(string name);
        Task<Sector?> GetSectorByDoctorNameAsync(string doctorName);
        Task<IEnumerable<Sector?>> GetAllSectorsAsync();

        Task? CreateSectorAsync(Sector sector);
        Task? UpdateSectorAsync(Sector sector);
        Task? DeleteSectorAsync(Sector sector);
    }
}
