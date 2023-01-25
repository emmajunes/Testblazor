using BlazorToDoList.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorToDoList.Services
{
    public class TaskService : ITaskService
    {
        private readonly HttpClientWrapperService _httpClientWrapper;

        public TaskService(HttpClientWrapperService client)
        {
            _httpClientWrapper = client;
        }

        public ToDoListItem AddTask(string taskTitle, string taskDescription, Priority taskPrio)
        {
            var path = "Task/AddTask";
            throw new NotImplementedException();
        }

        public void ChangeSortTypeForTask(SortTask sortAlternative)
        {
           
            throw new NotImplementedException();
        }

        public void DeleteTask()
        {
            var path = "Task/DeleteTask";
            throw new NotImplementedException();
        }

        public TaskItem EditTask(string? title, string? description, Priority? prio)
        {
            var path = "Task/EditTask";
            throw new NotImplementedException();
        }

        public async Task<TaskItem>GetSingleTaskAsync(Guid taskId)
        {
            var path = "Task/GetSingleTask";
            return await _httpClientWrapper.GetAsync<TaskItem>(path);
        }

        public async Task<IEnumerable<TaskItem>> GetTasksAsync()
        {
            var path = "Task/GetAllTasks";
            var result = await _httpClientWrapper.GetAsync<IEnumerable<TaskItem>>(path);

            return result;
        }

        public IEnumerable<TaskItem> SortTasks(SortTask sortAlternative)
        {
            var path = "Task/SortTasks";
            throw new NotImplementedException();
        }

        public TaskItem ToggleTask(bool completed)
        {
            var path = "Task/ToggleTask";
            throw new NotImplementedException();
        }
    }
}
