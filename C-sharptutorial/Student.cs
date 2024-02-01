using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharptutorial
{

    public class Student<T> 
    {

        public int Id { get; set; }

        public static void Calculator2(T value1, T value2)
        {
            Console.WriteLine("Value 1 = {0} and and Value2 = {1}", value1, value2);
        }

        public static void PrintData(T value1, T value2, T Value3)
        {

        }

        public static int[] Calculator3(int value1, int value2, int value3)
        {
            var result = value1 + value2 * value3;
            var data = value1 + value2 + value3;
            return new []{data,data };
        }
    }

   
}
