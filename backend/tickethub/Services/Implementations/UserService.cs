using tickethub.Repositories.Interfaces;
using tickethub.Services.Interfaces;

namespace tickethub.Services.Implementations
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> AuthenticateAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(User user)
        {
            await userRepository.UpdateAsync(user);
        }
    }
}
