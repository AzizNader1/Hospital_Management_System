using HMS.Domain.Entities;

namespace HMS.Domain.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient?> GetPatientByIdAsync(int id);
        Task<Patient?> GetPatientByNameAsync(string name);
        Task<IEnumerable<Patient?>> GetAllPatientsAsync();

        Task? CreatePatientAsync(Patient patient);
        Task? UpdatePatientAsync(Patient patient);
        Task? DeletePatientAsync(Patient patient);

    }
}
