using System;

namespace Aula132.Entities {
    class Employee {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() {
        }

        public Employee(string name, int hours, double valuePH) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePH;
        }

        public virtual double Payment() {
            return Hours * ValuePerHour;
        }
    }
}
