//mainMethod
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        try
        {
            int[] values = { 1, 28, 9, 0, 98, 9, 87, 5, 7 };
            Console.WriteLine(values[11]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}