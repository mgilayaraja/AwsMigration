using AwsMigration.Contracts.IRepositories;
using AwsMigration.Contracts.IServices;
using AwsMigration.Models.User;

namespace AwsMigration.Services
{
    public class UserService : IUserService
    {
        #region Declaration
        private readonly IUserRepository _userRepository;
        #endregion
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetUserByEmail(string emailAddress)
        {
            return _userRepository.GetUserByEmail(emailAddress);
        }
    }
}
