using BlazorToDoList.Data;
using ToDoList.API.Models;

namespace BlazorToDoList.Services
{
    public interface IListService
    {
        Task<ToDoListItem> CreateListAsync(ToDoListItem list);
        Task<ToDoListItem> DeleteListAsync();
        Task<IEnumerable<ToDoListItem>> GetCurrentUserListsAsync();
        Task<ToDoListItem> GetSingleListAsync(Guid listId);
        Task<IEnumerable<ToDoListItem>> GetAllListsAsync();
        Task<ToDoListItem> EditListAsync(ToDoListItem list);
        Task<ToDoListItem> EditTitleColorAsync(ToDoListItem list);
        Task<IEnumerable<ToDoListItem>> SortListsAsync(UserItem user);
    }
}