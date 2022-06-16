using APIConsumerLiveDemo.Models;
using ITUStudentLife.Shared.User;
using System;
using System.Threading.Tasks;

namespace APIConsumerLiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just to make it run in console. Use what is in "ContactAPI()".
            //Hvis den crasher her, er det fordi brugeren allerede findes i databasen. Ryd databasen, eller skift navn på brugeren. Det er en bug i API'et.
            Program program = new Program();
            program.ContactAPI().GetAwaiter().GetResult();
        }

        async Task ContactAPI()
        {
            //Sets up a userhandler, using localhost API.
            IUserHandler userHandler = new UserHandler(new LocalhostDataStore().GetHTTPClient());

            //Make a DTO if your method needs one (create, update).
            UserCreateDTO userToBeCreated = new UserCreateDTO
            {
                FirstName = "John2313",
                LastName = "Exampl2"
            };
                        
            //Use the userhandler to make the API call.
            UserDetailedDTO createdUser = await userHandler.CreateUserAsync(userToBeCreated);

            //Here is what you get back:
            if (createdUser != null) {
                Console.WriteLine("Created: " + createdUser.Id + ", " + createdUser.FirstName + " " + createdUser.LastName);
            }else {
                Console.WriteLine("The user was not created..!");
            }

            //Here is how you can read data by get-requests:
            UserDetailedDTO user = await userHandler.ReadUserAsync(1);
            if (user != null){
                Console.WriteLine("User with ID=1: " + user.FirstName + " " + user.LastName);
            }else{
                Console.WriteLine("User not found!");
            }          

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
