using System;

namespace test2
{
    class Person { }
    class Book { }
    class Employee
    {
        public string Surname;
    }


    class Program
    {
        static void Main(string[] args)
        {
Employee employee2 = null;
Console.WriteLine($"{employee2?.Surname ?? "Noname"}");
//is same to 
if (employee2 != null)
    Console.WriteLine($"{employee2?.Surname}");
else
    Console.WriteLine("Noname");



            Console.ReadKey();
        }
    }
}
