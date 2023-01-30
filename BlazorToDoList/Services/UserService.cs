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
            return await _httpClientWrapper.PostAsync<UserItem>(path, data);
        }


        public async Task<UserItem> CreateUserAsync(UserItem user)
        {
            var path = "User/CreateUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PostAsync<UserItem>(path, data);

        }

        public async Task<UserItem> DeleteUserAsync()
        {
            var path = "User/DeleteUser";
             return await _httpClientWrapper.DeleteAsync<UserItem>(path);
        }

        public async Task<UserItem> EditProfileAsync(UserItem user)
        {
            var path = "User/EditProfile";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<UserItem>(path, data);
        }

        public async Task<UserItem> GetSingleUserAsync()
        {
            var path = "User/GetSingleUser";
            return await _httpClientWrapper.GetAsync<UserItem>(path);
        }

        public async Task<IEnumerable<UserItem>> GetUsersAsync()
        {
            var path = "User/GetAllUsers";
            return await _httpClientWrapper.GetAsync<IEnumerable<UserItem>>(path);
        }

        public async Task<UserItem> DemoteUserAsync(UserItem user)
        {
            var path = "User/DemoteUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<UserItem>(path, data);
        }

        public async Task<UserItem> PromoteUserAsync(UserItem user) //ändrat från guid och access
        {
            var path = "User/PromoteUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<UserItem>(path, data);
        }

        public async Task<UserItem>ChangeSortType(UserItem user)
        {
            var path = "User/ChangeSortType";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return await _httpClientWrapper.PutAsync<UserItem>(path, data);
        }

    }
}
