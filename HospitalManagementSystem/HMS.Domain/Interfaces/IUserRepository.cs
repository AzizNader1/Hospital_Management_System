using HMS.Domain.Entities;

namespace HMS.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> GetUserByNameAsync(string name);
        Task<IEnumerable<User?>> GetAllUsersAsync();
        Task<IEnumerable<User?>> GetAllUsersByRoleAsync(string role);

        Task? CreateUserAsync(User user);
        Task? UpdateUserAsync(User user);
        Task? DeleteUserAsync(User user);

    }
}
