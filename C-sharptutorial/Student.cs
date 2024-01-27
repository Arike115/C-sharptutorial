using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{
    public enum DaysOfTheWeek
    { 
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Gender
    {
        Male,
        Female,
        unknown,
        Other
    }



    public class Student 
    {

        public int Id { get; set; }
       
       public static void userinfo()
        {
            Console.WriteLine("this method returns nothing");
            Console.WriteLine(Gender.Male);
        }

        public static int Calculator()
        {
            int v = 56; 
           int x = 78;
          var result = v * x;
            return result;
        }

        public static void Calculator2(int value1, int value2)
        {
            var result = value1 + value2;
            Console.WriteLine(result);
        }

        public static int[] Calculator3(int value1, int value2, int value3)
        {
            var result = value1 + value2 * value3;
            var data = value1 + value2 + value3;
            return new []{data,data };
        }
    }

    public class User 
    {
        public void MyMethod()
        {

        }

    }

}
