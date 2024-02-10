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

      //List<CarModule> carlist = new List<CarModule>();
        CarModule carList1 = new CarModule() {CarId = 201, Name = "Honda", Price = 2000000, Model = 2002 } ;
        CarModule carList2 = new CarModule() { CarId = 202, Name = "SUV", Price = 3000000, Model = 2005 };
        CarModule carList3 = new CarModule() { CarId = 203, Name = "Camry", Price = 4500000, Model = 2012 };
        CarModule carList4 = new CarModule() { CarId = 204, Name = "Peugot", Price = 1500000, Model = 2022 };
        CarModule carList5 = new CarModule() { CarId = 205, Name = "Bugatti", Price = 2000000, Model = 1890 };
        CarModule carList6 = new CarModule() { CarId = 206, Name = "Ferrari", Price = 2500000, Model = 1999 };


        Dictionary<int, CarModule> cardictionary = new Dictionary<int, CarModule>();
        cardictionary.Add(carList1.CarId, carList1);
        cardictionary.Add(carList2.CarId, carList2);
        cardictionary.Add(carList3.CarId, carList3);
        cardictionary.Add(carList4.CarId, carList4);
        cardictionary.Add(carList5.CarId, carList5);
        cardictionary.Add(carList6.CarId, carList6);

        foreach (var item in cardictionary)
        {
            Console.WriteLine("Key" + "  "+ item.Key);
            var car = item.Value;
            Console.WriteLine( "Name = {0}, Price = {1}, Model = {2}", car.Name, car.Price, car.Model );

        }

    }
}
