//mainMethod
using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    //linq (language integrated query)
    //linq 
    //query syntax
    //method syntax
    private static void Main(string[] args) //method
    {

        //int[] numbs = new int[] { 2, 12, 8, 6, 10, 4 };
        ////Query syntax
        //var res = from a in numbs where a > 3 orderby a select a;
        //foreach (int i in res)
        //    Console.WriteLine(i);

        IList<CarModule> list = new List<CarModule>()
        { 
           new CarModule() {CarId = 101, Name = "suv", Model = 2002, Price=3000 },
           new CarModule() {CarId = 102, Name = "Corolla", Model = 2023, Price=35000 },
           new CarModule() {CarId = 103, Name = "Hundai", Model = 2022, Price=8000 },
           new CarModule() {CarId = 104, Name = "Honda", Model = 1984, Price=10000 },

        };

        //method syntax

        var carlist = list.Where(s => s.Price > 3000)
                            .OrderBy(s => s.Name)
                            .Select(s => s.Name);

        foreach (var item in carlist)
        {
            Console.WriteLine(item);
        }

    }
}
