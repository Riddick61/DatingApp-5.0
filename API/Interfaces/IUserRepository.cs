using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);   
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetsUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsername(string username);
    }
}