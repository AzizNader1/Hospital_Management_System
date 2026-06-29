using HMS.Domain.Entities;

namespace HMS.Domain.Interfaces
{
    public interface IAppoitmentRepository
    {
        Task<Appoitment?> GetAppoitmentByIdAsync(int id);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsAsync();
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByPatientIdAsync(int patientId);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByPatientNameAsync(string patientName);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByDoctorIdAsync(int doctorId);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByDoctorNameAsync(string doctorName);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByDateAsync(DateOnly date);
        Task<IEnumerable<Appoitment?>> GetAllAppoitmentsByStatusAsync(string status);

        Task? CreateAppoitment(Appoitment appoitment);
        Task? UpdateAppoitmentAsync(Appoitment appoitment);
        Task? DeleteAppoitmentAsync(Appoitment appoitment);

    }
}
