using System;
using Task_7.Dto;
using Task_7.Interface;

namespace Task_7.Service
{
    public class UserService : IUserService
    {
        private static bool PasswordString(string passwordValue)
        {

            if (passwordValue.Any(char.IsLower) && passwordValue.Any(char.IsUpper) && passwordValue.Any(char.IsDigit))
            {
                return true;
            }
            return false;



        }

        public List<User> GetUserAll()
        {
            List<User> users = new List<User>()
            {
                 new User
            {
            Id= Guid.NewGuid(),
            Email="jondoe34@gmail.com",
            FullName = "johndoe34",
            Password = "secret56R12"
            },
            new User
            {
             Id= Guid.NewGuid(),
            Email="johndoe23@gmail.com",
            FullName = "johndoe23",
            Password = "secret3R12"
            },
            new User
            {
            Id = Guid.NewGuid(),
            Email="johndoe13@gmail.com",
            FullName = "johndoe34",
            Password = "secret2R12"
            },
            new User
            {
            Id = Guid.NewGuid(),
            Email="johndoe2334@gmail.com",
            FullName = "johndoe2367",
            Password = "secret1R12"
            }
            };




            return users;

        }

        public bool PasswordChecker(string passwordValue)
        {
            if (passwordValue.Length < 7)
            {
                return false;
            }
            else
            {
                if (!PasswordString(passwordValue))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
