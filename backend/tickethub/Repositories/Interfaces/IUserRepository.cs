namespace tickethub.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> AuthenticateAsync(String email, String password);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
