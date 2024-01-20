using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    //static
    public static class User
    {
        public static int v = 56;
        public static decimal Age { get; set; }

        public static void UserInfo()
        {
            Console.WriteLine("this user is blessed");
        }
    }
}
