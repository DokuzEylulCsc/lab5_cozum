using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Fibonacci: Factorial
    {
        int number;

        public Fibonacci(int a)
        {
            number = a;
        }

        public int Number1 { get => number; set => number = value; }

        public override double calculate()
        {
            int x1 = 1, x2 = 1;
            int sum = x1 + x2;

            if(number == 1 || number == 2)
            {
                return 1;
            }

            for(int i = 3; i <= number; i++)
            {
                sum = x1 + x2;
                x1 = x2;
                x2 = sum;               
            }

            return sum;
        }

        public override void order()
        {
            int x1 = 0, x2 = 1;
            int sum = x2;

            Console.Write(x2 + " ");

            for (int i = 2; i <= number; i++)
            {
                sum = x1 + x2;
                Console.Write(sum + " ");
                x1 = x2;
                x2 = sum;               
            }
        }
    }
}
