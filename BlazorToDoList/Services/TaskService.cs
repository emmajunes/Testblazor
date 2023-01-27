using BlazorToDoList.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using BlazorToDoList.Pages;

namespace BlazorToDoList.Services
{
    public class TaskService : ITaskService
    {
        private readonly HttpClientWrapperService _httpClientWrapper;
        public TaskService(HttpClientWrapperService client)
        {
            _httpClientWrapper = client;
        }
        public async Task<TaskItem>AddTaskAsync(TaskItem task)
        {
            var path = "Task/AddTask";
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PostAsync<TaskItem>(path, data);
        }

        //public void ChangeSortTypeForTask(SortTask sortAlternative)
        //{
           
        //    throw new NotImplementedException();
        //}

        public async Task<TaskItem> DeleteTaskAsync()
        {
            var path = "Task/DeleteTask";
            return await _httpClientWrapper.DeleteAsync<TaskItem>(path);
        }

        public async Task<TaskItem> EditTaskAsync(TaskItem task)
        {
            var path = "Task/EditTask";
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<TaskItem>(path, data);
        }

        public async Task<TaskItem>GetSingleTaskAsync(Guid taskId)
        {
            var path = "Task/GetSingleTask";
            var stringContent = JsonSerializer.Serialize(taskId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<TaskItem>(path,data);
        }

        public async Task<IEnumerable<TaskItem>> GetTasksAsync()
        {
            var path = "Task/GetAllTasks";
            var result = await _httpClientWrapper.GetAsync<IEnumerable<TaskItem>>(path);

            return result;
        }
        public async Task<IEnumerable<TaskItem>> SortTasksAsync(ToDoListItem listItem)
        {
            var path = "Task/SortTasks";
            var stringContent = JsonSerializer.Serialize(listItem);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<IEnumerable<TaskItem>>(path, data);
        }
        public async Task<TaskItem> ToggleTaskAsync(TaskItem task)
        {
            var path = "Task/ToggleTask";
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<TaskItem>(path, data);

        }
    }
}
