using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Program
{
    private static async Task Main(string[] args) //method
    {
        Task<int> result = MyMethod();
        MyMethod2();

        var data = await result;
        DisplayData(data);
        Console.ReadKey();

    }

    public static async Task<int> MyMethod()
    {
        Console.WriteLine("FirstProcess started");
        await Task.Delay(4000);
        Console.WriteLine("FirstProcess is completed");
        return 10;
    }

    public static async Task<int> MyMethod2()
    {
        Console.WriteLine("SecondProcess started");
        //await Task.Delay(4000);
        Console.WriteLine("SecondProcess is completed");
        return 20;
    }

    public static void DisplayData(int result)
    {
        Console.WriteLine(result);
    }
}
