using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            int sum = 0;
            Console.WriteLine("Enter the first number");
            number1=Console.ReadLine();
            Console.WriteLine("Enter the Second number");
            number2=Console.ReadLine();
            sum = number1 + number2;
            Console.WriteLine("The sum is = " + sum);
            Console.ReadKey();
        }
    }
}
