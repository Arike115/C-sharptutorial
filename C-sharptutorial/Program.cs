//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        int i = 56;
        var result = i.IsGreaterThan(500);
        Console.WriteLine(result);

        string v = "data";
        var data = v.Count();
    }
}