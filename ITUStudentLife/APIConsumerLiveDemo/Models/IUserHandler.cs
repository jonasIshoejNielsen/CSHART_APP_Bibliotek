using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ITUStudentLife.Shared.User;

namespace APIConsumerLiveDemo.Models
{
    public interface IUserHandler
    {
        Task<UserDetailedDTO> CreateUserAsync(UserCreateDTO user);
        Task<UserDetailedDTO> ReadUserAsync(int userId);
    }
}
