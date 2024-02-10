//mainMethod
using C_sharptutorial;
using Microsoft.VisualBasic;
using System.Net.Security;
using System.Reflection.Emit;

internal class Program
{
    //list
    //stack,
    //queue
    //Dictionary
    private static void Main(string[] args) //method
    {

     //   //list 
     //List<int> numbers = new List<int>();
     //   numbers.Add(17);
     //   numbers.Add(56);
     //   numbers.Add(90);
     //   numbers.Add(78);
     //   numbers.Add(11);
     //   numbers.Add(88);
     //   numbers.Add(22);
     //   numbers.Add(12);
     //   numbers.Add(21);

     //   foreach (int i in numbers)
     //   {
     //       Console.WriteLine(i);
     //   }

     //   //Queue(First In First Out)
     //   Queue<string> Words = new Queue<string>();

     //   Words.Enqueue("Chalk");
     //   Words.Enqueue("Board");
     //   Words.Enqueue("Purse");
     //   Words.Enqueue("Bag");
     //   Words.Enqueue("Nylon");
     //   Words.Enqueue("Mirror");

     //   var data = Words.Dequeue();
     //   Console.WriteLine(data);

     //   Console.WriteLine("Total elements: {0}", Words.Count());

     //   if(Words.Count > 0)
     //   {
     //       Console.WriteLine(Words.Peek());
     //   }
     //   Console.WriteLine("Total elements: {0}", Words.Count());
     //   var datas = Words.Dequeue();
     //   Console.WriteLine(datas);
     //   Console.WriteLine("Total elements: {0}", Words.Count());


        //Stack(Last In First Out)
        Stack<int> stacklist = new Stack<int>();
        stacklist.Push(89);
        stacklist.Push(9);
        stacklist.Push(80);
        stacklist.Push(92);
        stacklist.Push(22);
        stacklist.Push(30);

        Console.WriteLine("Numbers of element in stack :{0}", stacklist.Count());

        while(stacklist.Count > 0)
        {
            Console.Write(stacklist.Pop() + " ,");
        }
        Console.Write("Numbers of element in stack :{0}", stacklist.Count());

    }
}
