using System;

namespace Question08
{
    class Program
    {
        static void prime(int number)
        {
            Boolean flag = false;
            for(int i=2;i<=number/2;i=i+1)
            {
                if(number%i==0)
                {
                    flag = true;
                    break;
                }
            }
            if(flag==false)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine(" Not a  Prime number");
            }
        }
        static void Main(string[] args)
        {
            int number = 9;
            prime(number);
            Console.ReadKey();
        }
    }
}
