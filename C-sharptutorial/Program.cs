//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {

        Student.userinfo();
       var result = Student.Calculator();
        Student.Calculator2(result, 78);
        Student.Calculator3(78,90,87);
        
        
    }

}