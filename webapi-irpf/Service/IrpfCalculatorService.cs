using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using irpf.models;

namespace irpf.Service
{
    public class IrpfCalculatorService
    {
        private Person person;
        private IrpfCalculator calculator;

        public IrpfCalculatorService(int year, double totalSalary, int dependentsNumber) 
        {
            this.person = new Person(totalSalary, dependentsNumber);
            this.calculator = new IrpfCalculator(year, person);
        }

        public double CalculateBaseSalary() {
            return this.calculator.GetBaseSalary();
        }

        public double CalculateDiscount() {
            return this.calculator.GetTotalDiscount();
        }

        public double Calculate() {
            return this.calculator.GetValue();
        }
    }
}