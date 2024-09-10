using UserManagement.Domain.Common;
using UserManagement.Domain.User;

namespace UserManagement.Application.Services
{
    
    public abstract class UserManagementService
    {
        private readonly Logging _logger;
        private readonly IUserRepository _userRepository;

        public UserManagementService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IUserRepository CreateUser(string username, string email)
        {
            _logger.LogInformation("User operation started.");
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Username and email are required");
            }

            var user = new IUser
            {
                Username = username,
                Email = email
            };

            _userRepository.Add(user);

            return user;
        }

        public IEnumerable<IUser> GetAllUsers()
        {
            Guid userId;
            return _userRepository.GetUserByIdAsync(userId);
        }

        public IUserRepository GetUserById(int id)
        {
            // Business logic to get a user by ID
            return _userRepository.GetUserByIdAsync(id);
        }

        public void UpdateUser(User user)
        {
            // Business logic to update user
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            // Business logic to delete user
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                throw new KeyNotFoundException("User not found");
            }

            _userRepository.Delete(user);
        }
    }
}
