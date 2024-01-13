//mainMethod
using C_sharptutorial;
using System.Net.Security;

internal class Program
{
    //Comments
    //Variables
    //datatypes
    //constants 
    //converion method
    // single line comments
    /* multi-line comments*/

    //this is a main method which is called an entry point
    private static void Main(string[] args)
    {
        //datatypes
        //integer int
        //string
        //float
        //boolean bool
        //decimal
        //double
        //long
        //byte
        //int v = 568988977;
        //int number = 76;
        //Console.WriteLine(v);
        //Console.WriteLine(number);

        //string FirstName = "Precious";
        //string LastName = "Alape";
        //Console.WriteLine("My Name is "+ FirstName +" "+ LastName);

        //float x = 43634543;
        //bool y = false;
        //decimal values = 899.7875m;
        //double numerical = 786857875444.7865;
        //DateTime dateonly = DateTime.Now;
        //Console.WriteLine(dateonly);

        //const int data = 5463;
       
        //Console.WriteLine(data);
        WelcomeMemo();
        Arithmetic();
    }
    static void WelcomeMemo()
    {
        //Conversion
        //implicitcasting
        //explicitcasting

        //implicit -casting
        int data1 = 78;
        double data2 = data1;
        Console.WriteLine(data2);

        //explicit-casting
        double v = 456.22;
        int v2 = (int)v;
        Console.WriteLine(v2);

    }

    static void Arithmetic()
    {
        //arithmetic operators
        //+,-,*,/,%,++,--

        int v = 45;
        int x = 78;
        int d = v + x;
        int dt = v * x;
        int dx = v - x;
        int dy = v / x;
        Console.WriteLine("Addition =" + d);
        Console.WriteLine("Subtraction =" + dx);
        Console.WriteLine("multiplication =" + dt);
        Console.WriteLine("division =" + dy);

        //assignment
        //=, +=,-=,*=,/=,!=, >>=,<<+,
    }
}