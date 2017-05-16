using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary.DefaultOperations
{
    public class Divide1Operation : IOperation
    {
        public string Name
        {
            get { return "divide"; }
        }
        public double Calc(int x, int y)
        {
            return x * 1d / y;
        }
    }
}
