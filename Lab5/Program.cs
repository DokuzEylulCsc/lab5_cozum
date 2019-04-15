using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            // create 2 fibonacci, 2 factorial and 2 permutation and 2 combination numbers
            //add them to the list
            // show their calculated values in console
            //order the added two fibonacci numbers and show their sequence in console

            numbers.Add(new Factorial(5));
            numbers.Add(new Factorial(7));
            numbers.Add(new Combination(6, 3));
            numbers.Add(new Combination(8, 5));
            numbers.Add(new Fibonacci(13));
            numbers.Add(new Fibonacci(7));

            printList(numbers);
            Console.ReadKey();
        }

        public static void printList(ArrayList numbers)
        {
            foreach(object o in numbers)
            {
                
                if (o is Combination)
                {
                    Combination c = o as Combination;
                    Console.WriteLine("Combination Numbers: (" + c.Number + "," + c.Number2 + ")  " + "Calculate: " + c.calculate());
                    continue;
                }
                if(o is Fibonacci)
                {
                    Fibonacci f = o as Fibonacci;
                    Console.WriteLine("Fibonacci Number: " + f.Number1 + "  Calculate: " + f.calculate());
                    Console.Write("Fibonacci Number: " + f.Number1 + "  Order: ");
                    f.order();
                    Console.WriteLine();
                    continue;
                }
                if (o is Factorial)
                {
                    Factorial f = o as Factorial;
                    Console.WriteLine("Factorial Number: " + f.Number + "  Calculate: " + f.calculate());
                }
            }
        }
    }
}
