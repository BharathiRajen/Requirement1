using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*User user01 = new User();
            User user02 = new User();*/

            User[] users = new User[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter User {0} Details:", i + 1);
                string userdetails = Console.ReadLine();
                string[] users_details = userdetails.Split(',');
                users[i] = new User(users_details[0], users_details[1], users_details[2]);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("User {0}", i + 1);
                Console.WriteLine(users[i]);
            }
            if (users[0].Equals(users[1]))
            {
                Console.WriteLine("User 1 is same as User 2");
            }
            else
            {
                Console.WriteLine("User 1 is Different as User 2");
            }



        }

    }
}


