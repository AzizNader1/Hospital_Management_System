using HMS.Domain.Entities;

namespace HMS.Domain.Interfaces
{
    public interface IDaliyCheckUpRepository
    {
        Task<DailyCheckUp?> GetDailyCheckUpByIdAsync(int id);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsAsync();
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByPatientIdAsync(int patientId);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByPatientNameAsync(string patientName);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByDoctorIdAsync(int doctorId);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByDoctorNameAsync(string doctorName);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByDateAsync(DateOnly date);
        Task<IEnumerable<DailyCheckUp?>> GetAllDailyCheckUpsByStatusAsync(string status);

        Task? CreateDailyCheckUp(DailyCheckUp DailyCheckUp);
        Task? UpdateDailyCheckUpAsync(DailyCheckUp DailyCheckUp);
        Task? DeleteDailyCheckUpAsync(DailyCheckUp DailyCheckUp);
    }
}
