using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int number;
            for (int i = 0; i < rows; i = i + 1)
            {
                number = 1;
                for (int j = 0; j <= i; j = j + 1)
                {
                    Console.Write(number);
                    number = number + 1;
                }
                Console.WriteLine(" ");

            }
        }
    }
}

