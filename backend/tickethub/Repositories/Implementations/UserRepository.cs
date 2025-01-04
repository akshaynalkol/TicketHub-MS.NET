using Microsoft.EntityFrameworkCore;
using tickethub.Repositories.Interfaces;

namespace tickethub.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
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

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAsync()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await ctx.Users.ToListAsync();
            }
        }

        public async Task UpdateAsync(User user)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Update(user);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
