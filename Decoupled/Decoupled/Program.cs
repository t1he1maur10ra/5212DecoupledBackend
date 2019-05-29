using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson p1 = new Employee("Jacob Van Silfhout", 30, "Welcome Bay");
            IPerson p2 = new Customer("Bob Newhart", 15, "Te Puke");

            Console.WriteLine(p1.DisplayInfo()+"\n");

            Console.WriteLine(p2.DisplayInfo() + "\n");

            Console.ReadLine();
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        string Address { get; set; }

        string DisplayInfo();
    }

    public class Employee : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; } = 60000;

        public string DisplayInfo()
        {
            return $"Employee Details...\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Address: {Address}";
        }
        public Employee(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }

    public class Customer : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string[] Purchases { get; set; } = { "View Master", "Tickle me Elmo", "PS4" };

        public string DisplayInfo()
        {
            string purchases = "";
            for (int i = 0; i < Purchases.Length; i++)
                purchases = purchases + $"Item {i + 1}: {Purchases[i]}\n";
            return $"Employee Details...\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Purchases...\n{purchases}";
        }
        public Customer(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
