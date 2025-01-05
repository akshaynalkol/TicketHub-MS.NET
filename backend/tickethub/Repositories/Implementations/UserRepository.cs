using Microsoft.EntityFrameworkCore;
using tickethub.Repositories.Interfaces;

namespace tickethub.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public async Task AddAsync(User user)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(user);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            using (var ctx = new ApplicationDbContext()) { 
                return await ctx.Users.FirstOrDefaultAsync(u=>u.Email == email && u.Password==password);
            }
        }

        public async Task<User> ValidateEmailAsync(string email)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await ctx.Users.FirstOrDefaultAsync(u => u.Email == email);
            }
        }

        public async Task<User> ValidatePhoneAsync(string phone)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await ctx.Users.FirstOrDefaultAsync(u => u.Phone == phone);
            }
        }

        public async Task<List<User>> GetAsync()
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await ctx.Users.ToListAsync();
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                return await ctx.Users.FindAsync(id);
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

        public async Task DeleteAsync(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                User user= await ctx.Users.FindAsync(id);
                ctx.Users.Remove(user);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
