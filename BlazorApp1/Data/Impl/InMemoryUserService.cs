using System;
using System.Collections.Generic;
using System.Linq;
using BlazorApp1.Models;

namespace BlazorApp1.Data.Impl
{
    public class InMemoryUserService : IUserService
    {

        User user;

        private List<User> users;
        public InMemoryUserService() {
            //Roles:
            //"User" = Can controll own ToDos 
            //"Admin" = Can controll all ToDos

            //SecurityLevel:
            //1 = Can view ToDos determined by Role
            //2 = Cam view, create and delete ToDos determined by Role

            users = new[] {
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "User",
                    BirthYear = 1986,
                    SecurityLevel = 2,
                    ID = 2,
                    UserName = "Troels"
                },
                new User {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "654321",
                    Role = "Admin",
                    BirthYear = 1998,
                    SecurityLevel = 1,
                    ID = 1,
                    UserName = "Jakob"
                },
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "654321",
                    Role = "Admin",
                    BirthYear = 1999,
                    ID = 3,
                    SecurityLevel = 2,
                    UserName = "Oliver"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }
            user = first;
            return first;
        }
    }
}