using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{            //derived class
   public class Student : User,IUser
    {
        
       public static void StudentGrade()
        {
            Console.WriteLine("my current grade is 2.1");
        }

        public static void StudentAge()
        {
            Console.WriteLine("I'm 20 Years Old");
        }

        public void UserFullName()
        {
            throw new NotImplementedException();
        }

        public void UserAddress()
        {
            throw new NotImplementedException();
        }
    }
}
