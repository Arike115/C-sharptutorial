//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        Student<int>.Calculator2(78,89);
        Student<string>.Calculator2("Hello", "Welcome");
        
    }

}