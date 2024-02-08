//mainMethod
using System.Net.Security;
using System.Reflection.Emit;


//xml documentation
//preprocessor directives
//abstraction
//encapsulation
//Ilist and icollection

/// <summary>
/// this class is called program.cs and it is very important in a project
/// </summary>
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

        Student.Result();
        Student.Result2();
      
    }
}

    /// <summary>
    /// this calls list information about student module
    /// </summary>
public class Student
{
    #region this student module start end here
    public int StudentId { get; set; }
    public string StdentName { get; set; }
    public int Age { get; set; }

      /// <summary>
      /// this method returns void and only welcome new users
      /// </summary>
    public static void Result ()
    {
        Console.WriteLine("Welcome to dotnet");
    }

    public static void Result2()
    {
        Console.WriteLine("Welcome to dotnet Core");
    }
    #endregion
    /// <summary>
    /// this method calculate interger values
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns>int</returns>
    public static int calculate (int value1, int value2)
    {
        var result = value1 + value2;
        return result;
    }

    

}
