using tickethub.DTO;
using tickethub.Helper;
using tickethub.Repositories;
using tickethub.Repositories.Interfaces;
using tickethub.Services.Interfaces;

namespace tickethub.Services.Implementations
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        private IConfiguration configuration;

        public UserService(IUserRepository userRepository,IConfiguration configuration)
        {
            this.userRepository = userRepository;
            this.configuration= configuration;
        }
        public async Task<AuthenticateResponse> AuthenticateAsync(string email, string password)
        {
            User user=await userRepository.AuthenticateAsync(email, password);
            if (user == null) return null;
            // Authentication successful so generate jwt token
            JwtTokenGenerator jwtTokenGenerator = new JwtTokenGenerator(configuration);
;           var token = jwtTokenGenerator.generateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public async Task<User> ValidateEmailAsync(string email)
        {
            return await userRepository.ValidateEmailAsync(email);
        }

        public async Task<User> ValidatePhoneAsync(string phone)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await userRepository.ValidatePhoneAsync(phone);
            }
        }

        public async Task AddAsync(User user)
        {
            await userRepository.AddAsync(user);
        }

        public async Task<List<User>> GetAsync()
        {
            return await userRepository.GetAsync(); 
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await userRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(User user)
        {
            await userRepository.UpdateAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await userRepository.DeleteAsync(id);
        }
    }
}
