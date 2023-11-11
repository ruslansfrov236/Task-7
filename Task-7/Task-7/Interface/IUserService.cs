using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_7.Dto;

namespace Task_7.Interface
{
    public interface IUserService
    {

      bool  PasswordChecker(string passwordValue);

        List<User> GetUserAll();
    }
}
