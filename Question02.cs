using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
       static void evenOrOdd(int number)
        {
            int remainder = number % 2;
            if(remainder==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number Is odd");
            }

        }
        static void Main(string[] args)
        {
            evenOrOdd(1312122);

            Console.ReadKey();
        }
    }
}
