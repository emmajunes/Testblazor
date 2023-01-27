using BlazorToDoList.Data;
using ToDoList.API.Models;

namespace BlazorToDoList.Services
{
    public interface IUserService
    {
        Task<UserItem> Authenticate(UserItem user);
        Task<UserItem> CreateUserAsync(UserItem user);

        Task<UserItem> DeleteUserAsync();

        Task<UserItem> EditProfileAsync(UserItem user);

        Task<UserItem> GetSingleUserAsync();
        Task<IEnumerable<UserItem>> GetUsersAsync();

        Task<UserItem> ChangeSortType(UserItem user);

        //Task<UserItem> DemoteUserAsync(Guid id, Access access);

        Task<UserItem> PromoteUserAsync(UserItem user);



    }
}
