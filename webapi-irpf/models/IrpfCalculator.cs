using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace irpf.models
{
    public class IrpfCalculator
    {
        private  int year;
        private RateTable2021 rateTable;
        private DiscountTable2021 discountTable;
        private Person person;

        public IrpfCalculator(int year, Person person) {
            this.year = year;
            this.person = person;
            this.rateTable = new RateTable2021();
            this.discountTable = new DiscountTable2021();
        }

        public double GetBaseSalary() {
            var totalSalary = this.person.totalSalary;
            var inssValue = this.rateTable.GetInssValue(totalSalary);
            var dependentsDiscount = this.discountTable.GetDependentsValue(this.person.dependentsNumber);

            return totalSalary - inssValue - dependentsDiscount;
        }

        public double GetTotalDiscount() {
            var totalSalary = this.person.totalSalary;
            var inssValue = this.rateTable.GetInssValue(totalSalary);
            var dependentsDiscount = discountTable.GetDependentsValue(this.person.dependentsNumber);
            var exemptionValue = this.discountTable.GetExemptionValue();

            return inssValue + dependentsDiscount + exemptionValue;
        }

        public double GetValue()  {
            var netSalary = this.person.totalSalary - this.GetTotalDiscount();
            var taxValue = this.rateTable.getRate(netSalary);

            return netSalary * taxValue;
        }
    }
}