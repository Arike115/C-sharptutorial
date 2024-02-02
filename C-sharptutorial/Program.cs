//mainMethod
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
       IList<Student> studentlist = new List<Student>() 
       { 
           new Student() {StudentId = 1, StdentName = "John", Age = 18},
           new Student() {StudentId = 2, StdentName = "Steve", Age = 21},
           new Student() {StudentId = 3, StdentName = "Bil", Age = 18},
           new Student() {StudentId = 4, StdentName = "Tom", Age = 20},
           new Student() {StudentId = 5, StdentName = "Joy", Age = 21}
       };


        var students = from s in studentlist
                       select new {Id = s.StudentId, Name = s.StdentName, Age = s.Age};


        foreach ( var student in students )
        {
            Console.WriteLine(student.Id + " " + student.Name + " " + student.Age);
        }
      
    }
}


public class Student
{ 
    public int StudentId { get; set; } 
    public string StdentName { get; set; }
    public int Age { get; set; }

}
