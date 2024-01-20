using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    //access-modifiers
    //public 
    //private
    //internal
    //protected
    //static and nonstatic
    //Nonstatic
   public class Student
    {
        
        public int Id = 0;
        public String Name = "";
        public int Age = 0;
        public String Department = "";

        public Student(int id, string name, int age, string dept)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = dept;

        }

        public void StudentDetails()
        {
            Console.WriteLine("Her name is {0} From {1} Class,i'm {2} ", Name, Department, Age);
        }

        public static void StudentInfo()
        {
            Console.WriteLine("His name is Ben From Math Class");
        }


    }
}
