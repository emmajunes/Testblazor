using BlazorToDoList.Data;
using BlazorToDoList.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using ToDoList.API.Models;

namespace BlazorToDoList.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClientWrapperService _httpClientWrapper;

        public UserService(HttpClientWrapperService client)
        {
            _httpClientWrapper = client;
        }

        public async Task<UserItem> Authenticate(UserItem user)
        {
            var path = "User/Login";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var response = await _httpClientWrapper.PostAsync<UserItem>(path, data);
            
            return response;
        }


        public async Task<UserItem> CreateUser(UserItem user)
        {
            var path = "User/CreateUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var result = await _httpClientWrapper.PostAsync<UserItem>(path, data);

            return result;

        }

        public async Task<UserItem> DeleteUserAsync(Guid? id)
        {
            var path = "User/DeleteUser";
            var result = await _httpClientWrapper.DeleteAsync<UserItem>(path);
            return result;

        }


        public async Task<UserItem> EditProfile(UserItem user)
        {
            var path = "User/EditProfile";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var result = await _httpClientWrapper.PutAsync<UserItem>(path, data);

            return result;
        }

        public async Task<UserItem> GetIndividualUserAsync()
        {
            var path = "User/GetSingleUser";
            //var stringContent = JsonSerializer.Serialize(id);
            //var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.GetAsync<UserItem>(path);
        }

        public async Task<IEnumerable<UserItem>> GetUsersAsync()
        {
            var path = "User/GetAllUsers";
            var result = await _httpClientWrapper.GetAsync<IEnumerable<UserItem>>(path);

            return result;

        }

        //public UserItem DemoteUser(Guid id, Access access)
        //{
        //    var path = "User/DemoteUser";
        //    throw new NotImplementedException();
        //}

        public async Task<UserItem> PromoteUserAsync(UserItem user) //ändrat från guid och access
        {
            var path = "User/PromoteUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<UserItem>(path, data);
        }

    }
}
