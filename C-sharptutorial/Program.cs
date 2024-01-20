//mainMethod
using C_sharptutorial;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args) //method
    {
        User.UserInfo();
        User.Age = 88;
       
        Student.StudentInfo();

        //instatiation

        Student stud = new Student(101,"Grace",22,"Chemistry");
        stud.StudentDetails();
        
    }

}