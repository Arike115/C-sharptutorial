//mainMethod
using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    //Icollection
    //Ilist
    //Ienumerable
    private static void Main(string[] args) //method
    {
      IList<string> list = new List<string>() { "chalk","board","cup","mug"};
       list.Add("rubber");

        List<string> collection = new List<string>() { "chalk", "board", "cup", "mug" };
       

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }


    }
}
