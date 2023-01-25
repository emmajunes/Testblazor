using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ToDoList.API;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using BlazorToDoList.Data;
using System.Collections.Generic;

namespace BlazorToDoList.Services
{
    public class ListService : IListService
    {
        private readonly HttpClientWrapperService _httpClientWrapper;
        
        public ListService(HttpClientWrapperService client)
        {
            _httpClientWrapper = client;
        }

        //public void ChangeSortType(SortList sortAlternative, string userId)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ToDoListItem> CreateList(ToDoListItem listItem)
        //{
        //    var path = "List/CreateList";
        //    var result = await _httpClientWrapper.PostAsync<ToDoListItem>(path, listItem);

        //    return result;
        //}

        public async Task<ToDoListItem> DeleteListAsync()
        {
            var path = "List/DeleteList";
            return await _httpClientWrapper.DeleteAsync<ToDoListItem>(path);
  
        }

        //public ToDoListItem EditList(HttpContent content)
        //{
        //    var path = "List/EditList";
            
        //}
        //public ToDoListItem EditTitleColor(HttpContent content)
        //{

        //    var path = "List/EditTitleColor";
        //}

        public async Task<IEnumerable<ToDoListItem>> GetCurrentUserListsAsync()
        {
            var path =  "List/GetCurrentUserLists";
            return await _httpClientWrapper.GetAsync<IEnumerable<ToDoListItem>>(path);
        }

        public async Task<ToDoListItem> GetIndividualListAsync()
        {
            var path= "List/GetSingleList";
            return await _httpClientWrapper.GetAsync<ToDoListItem>(path);
        }

        public async Task<IEnumerable<ToDoListItem>> GetAllListsAsync()
        {
            var path = "List/GetAllLists";
            return await _httpClientWrapper.GetAsync<IEnumerable<ToDoListItem>>(path);

        }

        //public IEnumerable<ToDoListItem> SortLists(SortList sortAlternative, string userId)
        //{
        //    var path = "List/SortList";
        //}
    }
}
