using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    public abstract class BaseCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void LogInformation();
    }

    public class Customer : BaseCustomer
    {
        public Customer()
        {

        }
        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Spent { get; set; }
        public int ItemNum { get; set; }
        public override void LogInformation()
        {
            Console.WriteLine("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Money Spent?: ");
            Spent = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many Items");
            ItemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Avg Item Price = {(double)Spent/ItemNum}");
        }


    }
    public class Visitor: BaseCustomer
    {
        public string ReasonOfNoPurchase { get; set; }

        public override void LogInformation()
        {
            Console.WriteLine("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Why did you buy nothing?");
            ReasonOfNoPurchase = Console.ReadLine();
            Console.WriteLine(ReasonOfNoPurchase);
        }
    }
}
