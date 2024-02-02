//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        List<Student> studentlist = new List<Student>();    
        studentlist.Add(new Student() { Id = 001, Name = "Ben", Age = 10, Gender = Gender.Male, Class = "jss1"});
        studentlist.Add(new Student() { Id = 002, Name = "Grace", Age = 10, Gender = Gender.Female, Class = "jss2" });
        studentlist.Add(new Student() { Id = 003, Name = "Todd", Age = 14, Gender = Gender.Male, Class = "jss1" });
        studentlist.Add(new Student() { Id = 004, Name = "Mart", Age = 18, Gender = Gender.Male, Class = "jss3" });
        studentlist.Add(new Student() { Id = 005, Name = "Precious", Age = 11, Gender = Gender.Female, Class = "jss1" });
        studentlist.Add(new Student() { Id = 006, Name = "Victor", Age = 19, Gender = Gender.Male, Class = "jss3" });
        studentlist.Add(new Student() { Id = 007, Name = "Funmi", Age = 15, Gender = Gender.Female, Class = "jss2" });
        studentlist.Add(new Student() { Id = 008, Name = "ken", Age = 17, Gender = Gender.Male, Class = "jss1" });
        studentlist.Add(new Student() { Id = 009, Name = "Choice", Age = 16, Gender = Gender.Female, Class = "jss2" });
        studentlist.Add(new Student() { Id = 010, Name = "Lilian", Age = 16, Gender = Gender.Female, Class = "jss3" });
        studentlist.Add(new Student() { Id = 011, Name = "Femi", Age = 12, Gender = Gender.Male, Class = "jss1" });

        var result = studentlist.Select(em => em.Name).ToList();
        foreach (var student in result)
        {
            Console.WriteLine(student);
        }

        var data = studentlist.Sum(x => x.Id * x.Age);
        Console.WriteLine(data);


        //LambdaMethod();

    }


    public static void LambdaMethod()
    {
        List<int> numericalValues = new List<int>() { 34,5,6,89,90,75,7,8,9,0,8,12,14,24};
        var evenNumber = numericalValues.FindAll(x => (x%2)==0); 

        foreach ( var x in evenNumber )
        {
            Console.WriteLine(x);
        }
        Console.Read();
    }

   



}