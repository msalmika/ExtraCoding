using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCoding
{
    class Calculator
    {
        public int Result { get; private set; }

        public void Add(int num)
        {
            Result += num;
        }

        public void Substract(int num)
        {
            Result -= num;
        }

        public void Multiply(int num)
        {
            Result *= num;
        }

        public void Divide(int num)
        {
            Result /= num;
        }
    }
}
