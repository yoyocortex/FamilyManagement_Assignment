using System;
using System.Collections.Generic;
using System.Linq;
using Family.Models;

namespace Family.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    City = "Aarhus",
                    Domain = "via.dk",
                    Password = "1234",
                    Role = "Student",
                    BirthYear = 1999,
                    SecurityLevel = 3,
                    UserName = "Karlo"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Jakob"
                },
                new User
                {
                    City = "Vejle",
                    Domain = "via.com",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1973,
                    SecurityLevel = 5,
                    UserName = "Kasper"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}