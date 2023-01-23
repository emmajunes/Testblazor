using BlazorToDoList.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public async Task<UserItem> CreateUser(UserItem user)
        {
            var path = "User/CreateUser";
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            var result = await _httpClientWrapper.PostAsync<UserItem>(path, data);

            return result;

        }

        public void DeleteUser(Guid? id)
        {
            var path = "User/DeleteUser";
            throw new NotImplementedException();
        }

        //public UserItem DemoteUser(Guid id, Access access)
        //{
        //    var path = "User/DemoteUser";
        //    throw new NotImplementedException();
        //}

        public UserItem EditProfile(Guid id, string? username, string? email, string? passwword)
        {
            var path = "User/EditProfile";
            throw new NotImplementedException();
        }

        public UserItem GetIndividualUser(Guid id)
        {
            var path = "User/GetSingleUser";
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserItem>> GetUsersAsync()
        {
            var path = "User/GetAllUsers";
            var result = await _httpClientWrapper.GetAsync<IEnumerable<UserItem>>(path);

            return result;

        }

        //public UserItem PromoteUser(Guid id, Access access)
        //{
        //    var path = "User/PromoteUser";
        //    throw new NotImplementedException();
        //}

    }
}
