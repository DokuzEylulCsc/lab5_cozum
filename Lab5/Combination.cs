using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
     class Combination: Factorial
    {
        int number2;


        public Combination(int a,int b)
        {
            base.Number = a;
            number2 = b;
        }

        public int Number2 { get => number2; set => number2 = value; }

        public override double calculate()
        {
            int number1 = base.Number;
            int f = number1;
            int sum = 1;
            int sum2 = 1;
            int sum3 = 1;
            while (f > 0)
            {
                sum *= f--;
            }
            f = number1 - number2;
            while (f > 0)
            {
                sum2 *= f--;
            }
            f = number2;
            while (f > 0)
            {
                sum3 *= f--;
            }
            sum = (sum) / (sum2 * sum3);

            return sum;
        }
    }
}
