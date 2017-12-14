using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseCalc.Interfaces
{
    public interface ICalculatorService
    {
        decimal Add(decimal a, decimal b);
        decimal Subtract(decimal a, decimal b);
        decimal Multiple(decimal a, decimal b);
        decimal Divide(decimal a, decimal b);
    }
}
