using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUStudentLife.Shared.User;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Net;

namespace APIConsumerLiveDemo.Models
{
    public class UserHandler : IUserHandler
    {
        HttpClient _client;

        public UserHandler(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserDetailedDTO> CreateUserAsync(UserCreateDTO user)
        {
            var response = await _client.PostAsJsonAsync("api/user", user);

            var userDetailDTO = await response.Content.ReadAsAsync<UserDetailedDTO>();

            //If the request is invalid or the user was not created, return null
            if(response.StatusCode.Equals(HttpStatusCode.BadRequest) || !(userDetailDTO.Id > 0))
            {
                return null;
            }
            
            return userDetailDTO;
        }

        public async Task<UserDetailedDTO> ReadUserAsync(int userId)
        {
            var response = await _client.GetAsync($"api/user/{userId}");

            var userDetailDTO = await response.Content.ReadAsAsync<UserDetailedDTO>();

            //If the user with that ID is not found or the user is invalid, return null
            if (response.StatusCode.Equals(HttpStatusCode.NotFound) || !(userDetailDTO.Id > 0))
            {
                return null;
            }

            return userDetailDTO;
        }
    }
}
