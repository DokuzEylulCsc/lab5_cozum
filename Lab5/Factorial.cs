using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Factorial: ICalculatable, IComparable
    {
        int number;
        DateTime calculation_date;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public DateTime Calculation_date
        {
            get
            {
                return calculation_date;
            }

            set
            {
                calculation_date = DateTime.Now;
            }
        }

        public Factorial(int a)
        {
            number = a;
            calculation_date = DateTime.Now;
        }

        public Factorial()
        {
            calculation_date = DateTime.Now;
        }

        public virtual double calculate()
        {
            int f = number;
            if (f == 0)
            {
                return 1;
            }
            int sum = 1;
            while (f > 0)
            {
                sum *= f--;
            }
            return sum;
        }

        public virtual void order()
        {

        }


    }
}
