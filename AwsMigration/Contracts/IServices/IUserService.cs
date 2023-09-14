using AwsMigration.Models.User;

namespace AwsMigration.Contracts.IServices
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string emailAddress);
    }
}
