using EnterpriseCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCalc.Calculate.Service
{
    public class CalculatorService : ICalculatorService
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Divide(decimal a, decimal b)
        {
                return a / b;
        }

        public decimal Multiple(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Subtract(decimal a, decimal b)
        {            
            return a - b; 
        }
    }
}
