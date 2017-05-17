using System;
using CalcLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelOperations
{
    public class ExelOperation : IOperation
    {
        public string Name => "exel";

        public double Calc(int x, int y)
        {
            return x * x + y * y + x - y;
        }
    }
}
