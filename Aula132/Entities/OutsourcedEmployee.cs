using System;

namespace Aula132.Entities {
    class OutsourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() {
        }

        public OutsourcedEmployee(string name, int hours, double value, double addCharge) 
        : base(name, hours, value){
            AdditionalCharge = addCharge;
        }

        public override double Payment() {
            return base.Payment() + 1.1 * AdditionalCharge;
            //retorna  o payment da classe pai + o adicioinal;
        }
    }
}
