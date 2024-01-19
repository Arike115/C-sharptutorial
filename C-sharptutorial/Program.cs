//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
   //operators
   //arithmetic operator
   //assignment operator
   //logical operator &&, ||, !
   //comparison operator ==, !=,>, <,>=,<=
   //Statement
   //conditional statement : if&else-statement, switchcase
   //looping
   //while
   //dowhile
   //for
   //foreach
    private static void Main(string[] args)
    {
        //assignmnet opertors =,+=,-=,*=,/=,%=,&=
        int y = 25;
        y += 23;
        y -= 10;
        y *= 10;
        y /= 2;
        Console.WriteLine(y);
        //ConditionalStatement();
        // CombinedMethod();
        //CombinedMethod2();
        SwitchCaseMethod();
    }

    static void ConditionalStatement()
    {
        int x = 654; int b = 90;
        int v = 654; int c = 76;

        if(x == v)
        {
            Console.WriteLine("the result is correct");
        }
        else 
        { 
            Console.WriteLine("the result is not correct");
        }

        if (b <= 100)
        {
            Console.WriteLine("b is greater");
        }
        else
        {
            Console.WriteLine("the value is greater");
        }
    }

    static void CombinedMethod()
    {
        Console.WriteLine("Hello what would you like you like to get");
        Console.WriteLine("select 1. for coffee, 2. for bread, 3 for tea");
        int result = int.Parse(Console.ReadLine());

        int x = 1;
        int b = 2;
        int v = 3;

        if(result ==  x || result == b || result == v)
        {
            Console.WriteLine("Thank you for your patronage");
        }
        else
        {
            Console.WriteLine("please select the right value");
        }
    }

    static void CombinedMethod2()
    {
        Console.WriteLine("Hello what would you like you like to get");
        Console.WriteLine("select 2. for bread");
        int result = int.Parse(Console.ReadLine());
        Console.WriteLine("Please input your 3 for your budget price");
        int result2 = int.Parse(Console.ReadLine());

        
        int b = 2;
        int v = 3;

        if (result == b && result2 == v)
        {
            Console.WriteLine("Thank you for your patronage");
        }
        else
        {
            Console.WriteLine("please select the right value");
        }
    }

    static void SwitchCaseMethod()
    {
        Start:
        Console.WriteLine("Please select days of the week in Numerical Format");
        int result = int.Parse(Console.ReadLine());
        switch(result)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
                default:
                Console.WriteLine("Value does not Exist");
                goto Start;
        }
    }


}