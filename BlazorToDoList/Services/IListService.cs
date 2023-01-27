using BlazorToDoList.Data;
using ToDoList.API.Models;

namespace BlazorToDoList.Services
{
    public interface IListService
    {
        Task<ToDoListItem> CreateListAsync(ToDoListItem listItem);
        Task<ToDoListItem> DeleteListAsync();
        Task<IEnumerable<ToDoListItem>> GetCurrentUserListsAsync();
        Task<ToDoListItem> GetSingleListAsync(Guid listId);

        Task<IEnumerable<ToDoListItem>> GetAllListsAsync();
        Task<ToDoListItem> EditListAsync(ToDoListItem listItem);

        Task<ToDoListItem> EditTitleColorAsync(ToDoListItem listItem);
        Task<IEnumerable<ToDoListItem>> SortListsAsync(UserItem user);






    }
}