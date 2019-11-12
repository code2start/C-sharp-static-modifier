using System;

namespace staicmodifiers
{
    public class Employee
    {
        private string name;
        public static int counter;
        /* static Employee()
        {
            counter = 20;
        } */

        public Employee(string name)
        {
            this.name = name;
            counter++;
        }

        public void ShowEmployeeNumber()
        {
            Console.WriteLine($"This Employee number is {counter}");
        }
    }
}