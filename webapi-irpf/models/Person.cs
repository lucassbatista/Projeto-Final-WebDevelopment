using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace irpf.models
{
    public class Person
    {

        public Person(double totalSalary, int dependentsNumber) 
        {
            this.totalSalary = totalSalary;
            this.dependentsNumber = dependentsNumber;
        }

        public double totalSalary {get; private set;}
        public int dependentsNumber {get; private set;}
    }
}