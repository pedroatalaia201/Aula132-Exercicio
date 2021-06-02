using System;
using System.Globalization;
using System.Collections.Generic;
using Aula132.Entities;

namespace Aula132 {
    class Program {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Employye #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char outS = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(outS == 'y') {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, value, addCharge));
                }
                else {
                    employees.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine("\nPAYMENTS:\n");

            foreach(Employee person in employees) {
                Console.WriteLine(person.Name + " - $ " + person.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
