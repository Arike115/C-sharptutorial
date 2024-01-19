//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
   //conditional statement : if&else-statement, switchcase
   //looping
   //while
   //dowhile
   //for
   //foreach
    private static void Main(string[] args)
    {
        ////Foreachloop
        //int v = 56;
        //Console.WriteLine(v);

        ////array
        //int[] numbers = { 1, 2, 3,89,94,84,90,57,34,3,4,0,1,1,1};
        //foreach(int i in numbers)
        //{
        //    Console.WriteLine(i);
        //}


        //Forloop
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        //do while

        int y = 0;
        do
        {
            Console.WriteLine("dowhile result is" +' '+ y);
            y++;
        }
        while (y < 20);

        //while

        int x = 0;
        while (x < 20)
        {
            Console.WriteLine("while result is" + ' ' + x);
            x++;
        }
        
    }




}