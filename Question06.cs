using System;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult;
            Console.WriteLine("Table");
            Console.WriteLine("Enter the number");
            int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Range of Table");
            int Range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for(int i=1;i<=Range;i=i+1)
            {
                mult = number * i;
                Console.WriteLine(mult);
               

            }
            Console.ReadKey();

        }
    }
}
