using System;
using Task_7.Dto;
using Task_7.Interface;
using Task_7.Service;

namespace YourNamespace
{
    public class Program
    {
        private readonly IUserService _userService;

        public Program(IUserService userService)
        {
            _userService = userService;
        }

      
        public void ShowInfo(){
              var data = _userService.GetUserAll();
             foreach (var item in data)
                {
                    Console.WriteLine($"User:{item.FullName}\n Email:{item.Email} \n Password:{item.Password}");
                }
        }
        public void UserStart()
        {
          
            Console.Write("1) Şifrede minimum 8 character olmalidir \r\n2) Şifrede en az 1 böyük herf olmalidir \r\n3) Şifrede en az 1 kiçik herf olmalidir \r\n4) Şifrede en az 1 reqem \n ");

           
            List<User> users = new List<User>();

            User user = new User();
            user.Id= Guid.NewGuid();
            Console.Write("Tam adini daxil edin :");
            user.FullName = Console.ReadLine();
            Console.Write("Email daxil edin :");
            user.Email = Console.ReadLine();
            Console.Write("Password daxil edin :");
            user.Password = Console.ReadLine();
         

       

             var  isPasswordValid = _userService.PasswordChecker(user.Password);
            if (isPasswordValid)
            {

                Console.WriteLine("Melumat elave edildi!");
                users.Add(user);
               

            }
          
            else
            {
                Console.WriteLine("Daxil olan serte uygun deyil");
            }


        }

        public static  void Main(string[] args)
        {
           
            IUserService userService = new UserService(); 

            Program program = new Program(userService);
            Console.WriteLine("1. Istifadeci qeydiyyatdan kecir.\n 2.Butun melumati gorur\n");
            Console.WriteLine("Secim et:");
            int secim_et= int.Parse( Console.ReadLine());
            switch(secim_et){
                case 1:
                program.UserStart();
                break;
                case 2:
                program.ShowInfo();
                break;
                default:
                 System.Console.WriteLine("Daxil olan eded her hansi serte uygun deyil ");
                 break;
            }
            
 
        }
    }
}
