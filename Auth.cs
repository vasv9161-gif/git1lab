using System;

namespace lab1git
{
    class Auth
    {
        public static bool CheckLogin(string login, string password)
        {
            return login == "admin" && password == "12345";
        }
    }
}