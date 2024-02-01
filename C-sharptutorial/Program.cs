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

        Ispromotable promoteresult = new Ispromotable(promote);

        Ispromotable promotedata = new Ispromotable(Promotewithage);


        Student.PromoteStudent(studentlist, promotedata);
        Console.WriteLine("result ..................");
        Student.PromoteStudent(studentlist, promoteresult);
    }

    public static bool promote(Student student)
    {
        if(student.Gender == Gender.Female)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool Promotewithage (Student student)
    {
        if (student.Age >= 16)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



}