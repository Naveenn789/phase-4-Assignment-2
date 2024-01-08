using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibUserAuth
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class UserAuthenticator
    {
        public List<Users> reg = new List<Users>();
        public string Registration(string name, string password)
        {
            if ((name.Length >= 4))
            {
                var user = new Users
                {
                    UserName = name,
                    Password = password
                };
                reg = new List<Users>()
                {
                   user
                };
                return "Registration Sucessfull";
            }
            else
            {
                return "Registration Unsucessfull";
            }
        }
        public string UserLogin(string name, string password)
        {
            reg = new List<Users>()
            {
                new Users {UserName = "Priya", Password = "Priya@123"},
            };
            string result = "";
            string n = "";
            foreach (var u in reg)
            {
                if ((u.UserName==name) && (u.Password==password))
                {
                    result = "User Found";
                }
                else
                {
                    result = "User Not Found";
                }
            }
            
            return result;
        }
    }
}
