//mainMethod
using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Program
{
   //set operators
   //element operators
   //conversion  method
   //aggregate operators
   //Quantifiers
    private static void Main(string[] args) //method
    {
        int[] Numerical1 = { 1, 2, 3, 4, 5, 5, 6, 6, 7, 7 };
        int[] Numerical2 = { 7, 7, 8, 9, 10, 11, 12, 12,89 };
        int[] Numerical = { };
        string[] words = { };



        //Quantifiers
        var anymethod = Numerical2.Any(x => x % 2 == 0);
        Console.WriteLine(anymethod);
        var allmethod = Numerical2.All(x => x % 2 == 0);
        Console.WriteLine(allmethod);
        var Containmethod = Numerical2.Contains(7);
        Console.WriteLine(Containmethod);



        //aggregate operators
        //var result = Numerical1.ToList();
        // var counteven = result.Count(x => x % 2 == 0);
        // Console.WriteLine(counteven);
        // var sumvalue = result.Sum();
        // Console.WriteLine(sumvalue);
        // var maxvalue = result.Max();
        // Console.WriteLine(maxvalue);
        // var minvalue = result.Min();
        // Console.WriteLine(minvalue);
        // var averagevalue = result.Average();
        // Console.WriteLine(averagevalue);

        //ElementOperators
        //var firstnumber = Numerical.FirstOrDefault();
        //var secondnumber = Numerical1.First();
        //Console.WriteLine(secondnumber);
        //Console.WriteLine(firstnumber);

        //var lastdefaultnumber = words.LastOrDefault();
        //var lastnumber = Numerical2.Last();
        //Console.WriteLine(lastdefaultnumber);
        //Console.WriteLine(lastnumber);

        //var elementdefaultnumber = Numerical1.ElementAtOrDefault(15);
        //var elementnumber = Numerical2.ElementAt(7);
        //Console.WriteLine(elementdefaultnumber);
        //Console.WriteLine(elementnumber);



        //SetOperators

        //var distinctmethod = Numerical1.Distinct();

        //foreach (int i in distinctmethod)
        //{
        //    Console.WriteLine(i);
        //}


        //var unionmethod = Numerical1.Union(Numerical2).ToList();

        //foreach (int v in unionmethod)
        //{
        //    Console.WriteLine("union :" + string.Join(",", v));
        //}

        //var intersectmethod = Numerical1.Intersect(Numerical2).ToArray();

        //foreach (int v in intersectmethod)
        //{
        //    Console.WriteLine("intersect :" + string.Join(",", v));
        //}

        //var exceptmethod = Numerical1.Except(Numerical2);

        //foreach (int v in exceptmethod)
        //{
        //    Console.WriteLine("Except :" + string.Join(",", v));

        //}

        //var Concatmethod = Numerical1.Concat(Numerical2);

        //foreach (int v in Concatmethod)
        //{
        //    Console.WriteLine("Concat :" + string.Join(",", v));
        //}






    }
}
