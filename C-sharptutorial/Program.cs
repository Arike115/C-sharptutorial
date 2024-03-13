using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args) //method
    {
        //Directory

        //string root = @"C:\Temp";

        //if(Directory.Exists(root))
        //{
        //    Directory.Delete(root);
        //    Console.WriteLine("data deleted");
        //}

        //file

        //string file = @"C:\Document\Data.txt";
        //var result =File.GetLastWriteTimeUtc(file);
        //Console.WriteLine(result);
        //var result2 = File.GetLastAccessTime(file);
        //Console.WriteLine(result2);

        //var folder = @"C:\DataInfo\";
        //var filename = "Namelist.txt";
        //var fullpath =  folder + filename;

        //string[] userslist = { "james Ben", "Emmanuel Grace", "Tosin Lawal", "Tomike joy" };

        //File.WriteAllLines(fullpath, userslist);
        //var readtext = File.ReadAllText(fullpath);
        //Console.WriteLine(readtext);


        var folders = @"C:\Document";
        var filelist = Directory.GetFiles(folders);
        foreach (var files in filelist) 
        Console.WriteLine(files);

        Console.WriteLine(Directory.GetDirectoryRoot(folders));

    }

    
}
