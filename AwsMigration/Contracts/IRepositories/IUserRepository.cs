using AwsMigration.Models.User;

namespace AwsMigration.Contracts.IRepositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string emailAddress);
    }
}
