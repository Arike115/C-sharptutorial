//mainMethod
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        //escape sequence
        //\'
        //\"
        //\
        //\n
        //\r
        //\t
        //\0
        //\b

        string sample = "Hello\nVictor";
        string sample2 = "c:\\codebuns\\file.cs";
        string sample3 = "i am a \"junior developer\".";
        Console.WriteLine(sample);
        Console.WriteLine(sample2);
        Console.WriteLine(sample3);

    }

}