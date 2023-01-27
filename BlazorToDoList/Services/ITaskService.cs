using BlazorToDoList.Data;
using ToDoList.API.Models;

namespace BlazorToDoList.Services
{
    public interface ITaskService
    {
        Task<TaskItem> AddTaskAsync(TaskItem task);
        //void ChangeSortTypeForTask(SortTask sortAlternative);
        Task<TaskItem> DeleteTaskAsync();
        Task<TaskItem> EditTaskAsync(TaskItem task);

        Task<TaskItem> GetSingleTaskAsync(Guid taskId);

        Task<IEnumerable<TaskItem>> GetTasksAsync();

        Task<IEnumerable<TaskItem>> SortTasksAsync(ToDoListItem list);
        Task<TaskItem> ToggleTaskAsync(TaskItem task);




    }
}
