using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ToDoList.API;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using BlazorToDoList.Data;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;

namespace BlazorToDoList.Services
{
    public class ListService : IListService
    {
        private readonly HttpClientWrapperService _httpClientWrapper;
        
        public ListService(HttpClientWrapperService client)
        {
            _httpClientWrapper = client;
        }

        public async Task<ToDoListItem> CreateListAsync(ToDoListItem listItem)
        {
            var path = "List/CreateList";
            var stringContent = JsonSerializer.Serialize(listItem);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PostAsync<ToDoListItem>(path, data);

        }

        public async Task<ToDoListItem> DeleteListAsync()
        {
            var path = "List/DeleteList";
            return await _httpClientWrapper.DeleteAsync<ToDoListItem>(path);

        }

        public async Task<IEnumerable<ToDoListItem>> GetCurrentUserListsAsync()
        {
            var path =  "List/GetCurrentUserLists";
            return await _httpClientWrapper.GetAsync<IEnumerable<ToDoListItem>>(path);
        }

        public async Task<ToDoListItem> GetSingleListAsync(Guid listId)
        {
            var path= "List/GetSingleList";
            
            var stringContent = JsonSerializer.Serialize(listId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<ToDoListItem>(path, data);

        }

        public async Task<IEnumerable<ToDoListItem>> GetAllListsAsync()
        {
            var path = "List/GetAllLists";
            return await _httpClientWrapper.GetAsync<IEnumerable<ToDoListItem>>(path);

        }

        public async Task<ToDoListItem> EditListAsync(ToDoListItem listItem)
        {
            var path = "List/EditList";
            var stringContent = JsonSerializer.Serialize(listItem);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<ToDoListItem>(path, data);       

        }
        public async Task<ToDoListItem> EditTitleColorAsync(ToDoListItem listItem)
        {

            var path = "List/EditTitleColor";
            var stringContent = JsonSerializer.Serialize(listItem);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<ToDoListItem>(path, data);
        }

        public async Task<IEnumerable<ToDoListItem>> SortListsAsync(UserItem user)
        {
            var path = "List/SortList";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<IEnumerable<ToDoListItem>>(path, data);
        }
    }
}
