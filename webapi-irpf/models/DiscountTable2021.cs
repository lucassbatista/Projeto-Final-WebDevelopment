using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace irpf.models
{
    public class DiscountTable2021
    {
        private static readonly double DEPENDENTS_DISCOUNT = 189.59;
        private static readonly double EXEMPTION_VALUE = 1903.98;

        public double GetExemptionValue() {
            return EXEMPTION_VALUE;
        }

        public double GetDependentsValue(int number) {
            return number * DEPENDENTS_DISCOUNT;
        }
    }
}