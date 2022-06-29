using System.Collections.Generic;

namespace RabbitMQSenderConsoleApp
{
    internal class UserService
    {
        public UserService()
        {
        }

        internal List<User> GetAllUsersToSend()
        {
            List<User> userList = new List<User>();
            userList.Add(new User { FirstName = "rakesh", LastName = "kumar", EmailAddress = "abc@gmail.com" });
            userList.Add(new User { FirstName = "rakesh", LastName = "sharma", EmailAddress = "abc2@outsmarthub.co.nz" });

            return userList;
        }
    }
}