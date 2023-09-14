using AwsMigration.Contracts.IRepositories;
using AwsMigration.Models.User;

namespace AwsMigration.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> GetUserByEmail(string emailAddress)
        {
            return new User { EmailAddress = emailAddress };
        }
    }
}
