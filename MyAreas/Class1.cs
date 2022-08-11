using System;
using System.Collections.Generic;
namespace MyAreas
{
    public class Areas
    {
        public float Circle(int radius)
        {
            return (float)Math.PI * radius * radius;
        }
        public float Triangle(int b, int h)
        {
            return (float).5 * b * h;
        }
        public int Rectangle(int l, int b)
        {
            return l * b;
        }

        public string Login(string user, string pwd)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                return "user or pwd is null";
            }
            else if (user == "Admin" && pwd == "admin")
            {
                return "Welcome Admin";
            }
            else return "Invalid user and password";
        }
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Bob");
            names.Add("Don");
            names.Add("Thomas");
            names.Add("Sean");
            return names;
        }
    }
}
