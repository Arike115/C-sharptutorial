//mainMethod
using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Program
{
    //linq (language integrated query)
    //linq 
    //filtering e.g where
    //Projection e.g select, select many
    //ordering e.g orderby, orderbydescending
    //grouping e.g
    private static void Main(string[] args) //method
    {

        IList<CarModule> list = new List<CarModule>()
        { 
           new CarModule() {CarId = 101, Name = "suv", Model = 2002, Price=3000 },
           new CarModule() {CarId = 102, Name = "Corolla", Model = 2023, Price=35000 },
           new CarModule() {CarId = 103, Name = "Hundai", Model = 2022, Price=8000 },
           new CarModule() {CarId = 104, Name = "Honda", Model = 1984, Price=10000 },
           new CarModule() {CarId = 101, Name = "Toyota", Model = 2002, Price=3000 },
           new CarModule() {CarId = 103, Name = "Camry", Model = 2023, Price=35000 },
           new CarModule() {CarId = 103, Name = "Benz", Model = 2022, Price=8000 },
           new CarModule() {CarId = 104, Name = "Bugatti", Model = 1984, Price=10000 },

        };

        ////method syntax
        //var data = list.Select(x => x.Name);
        //var result = list.Where(s => s.CarId > 101).OrderByDescending(x => x.Name).ToList();
        ////
        //foreach (var module in data)
        //{
        //    Console.WriteLine(module);
        //}

        //Console.WriteLine("........");
        //foreach (var module in result)
        //{
        //    Console.WriteLine(module.Name);
        //}

        //Group By
        //Method Syntax
        var groupby =list.GroupBy(x => x.CarId);

        //Query syntax
        var groupQuery = (from std in list group std by std.CarId);

        foreach(var group in groupby)
        {
            Console.WriteLine(group.Key + ":" + group.Count());
            foreach(var datas in group)
            {
                Console.WriteLine(datas.Name);
            }
        }
    }
}
