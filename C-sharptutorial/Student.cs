using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{            //derived class
   public class Student 
    {
       public static void userinfo()
        {
            Console.WriteLine("this method returns nothing");
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
}
