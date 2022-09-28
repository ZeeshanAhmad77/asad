using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Method");

            Console.WriteLine("");
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");

            Console.WriteLine("");
            Console.WriteLine("2nd Method");

            int rows = 5;
            for(int i=0;i<rows;i=i+1)
            {
                for(int j=0;j<=i;j=j+1)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}
