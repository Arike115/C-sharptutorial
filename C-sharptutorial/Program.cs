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
        var customers = new List<Customer>
        { 
            new Customer { Id = 101, CustomerName = "Pedro", PhoneNumber="09037887890"},
            new Customer { Id = 102, CustomerName = "Alice", PhoneNumber="09037887111"},
            new Customer { Id = 103, CustomerName = "Roberto", PhoneNumber="08022887890"}
        };

        var Orders = new List<Order>
        {
            new Order {CustomerId = 101, OrderId = 1, ProductName = "Bag of Rice", Productprice = 80000},
            new Order {CustomerId = 102, OrderId = 2, ProductName = "Bag of Bean", Productprice = 60000},
            new Order {CustomerId = 102, OrderId = 3, ProductName = "Bag of Flour", Productprice = 76000},
            new Order {CustomerId = 102, OrderId = 4, ProductName = "Bag of Spagetti", Productprice = 18000},
            new Order {OrderId = 5, ProductName = "Bag of Semo", Productprice = 12000}
        };

        //inner Join  or Join
        //Method Syntax

        var joinlist = customers.Join(Orders,
                        x => x.Id, s => s.CustomerId,
                        (x, s) => new 
                        { 
                            CustomerName = x.CustomerName,
                            ItemName = s.ProductName,
                            Amount = s.Productprice
                        }).ToList();

        //Query Syntax
        var Queryjoinlist = (from c in customers
                            join o in Orders
                            on c.Id equals o.CustomerId
                            select new 
                            {
                                CustomerName = c.CustomerName,
                                ItemName = o.ProductName,
                                Amount = o.Productprice
                            }).ToList();



        //LeftJoin 
        //Query syntax 
        var queryleftjoin = from c in customers // left 
                            join o in Orders //right
                            on c.Id equals o.CustomerId
                            into datagroup
                            from groupinfo in datagroup.DefaultIfEmpty()
                            select new
                            {
                                CustomerName = c.CustomerName,
                                ItemName = groupinfo?.ProductName,
                                Amount = groupinfo?.Productprice
                            };

        //Method syntax 
        var methleftjoin = customers.GroupJoin(Orders,
                        x => x.Id, s => s.CustomerId,
                        (x, s) => new {x,s}
                        ).SelectMany
                        (
                        x => x.s.DefaultIfEmpty(),
                        (cust, ord) => new 
                        {
                            CustomerName = cust.x.CustomerName,
                            ItemName = ord == null ? "N/A" : ord.ProductName,
                            Amount = ord == null ? 0: ord.Productprice,
                        }).ToList();


        //RightJoin
        //querysyntax 

        var queryrightjoin = from c in Orders // left 
                             join o in customers //right
                             on c.CustomerId equals o.Id
                             into datagroup
                             from groupinfo in datagroup.DefaultIfEmpty()
                             select new
                             {
                                 CustomerName = c.ProductName,
                                 ItemName = groupinfo?.CustomerName,
                                 Amount = c.Productprice
                             };

        var fullouterjoin = customers.Join(Orders,
                                    x => true,
                                    s => true,
                                    (x, s) => new
                                    {
                                        CustomerName = x.CustomerName,
                                        ItemName = s.ProductName,
                                        Amount = s.Productprice
                                    });


        foreach (var data in fullouterjoin)
        {
            Console.WriteLine($"CustomerName: {data.CustomerName}, ItemName: {data.ItemName}, Amount: {data.Amount} ");
        }


    }
}
