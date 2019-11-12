using System;

namespace staicmodifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employee e1 = new Employee("Mohamed Fathy");
            Employee e2 = new Employee("Ahmed Mohamed");
            e1.ShowEmployeeNumber();
            Employee.counter;
        }
    }
}
