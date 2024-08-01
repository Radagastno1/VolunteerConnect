namespace CORE.Services;
    public class UserService : IUserService
    {
        // private readonly IUserRepository _userRepository;
        // private readonly ILogger<UserService> _logger;

        public UserService()
        {
            // _userRepository = userRepository;
            // _logger = logger;
        }

        public async Task<User> Create(User User)
        {
           throw new NotImplementedException();
        }

        public async Task<User> UpdateUser(User user)
        {
               throw new NotImplementedException();
        }

        public async Task<User> GetById(string id)
        {
                throw new NotImplementedException();
        }

        public async Task<bool> DeleteById(string id)
        {
                 throw new NotImplementedException();
        }
    }
