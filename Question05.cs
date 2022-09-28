using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static int[] LargestInList(int[] listOfNumber)
        {
            int temp;
            int size = listOfNumber.Length;
            for(int i=0;i<size;i=i+1)
            {
                for(int j=0;j<size;j=j+1)
                {
                    if (listOfNumber[i] > listOfNumber[j])
                    {
                        temp = listOfNumber[i];
                        listOfNumber[i] = listOfNumber[j];
                        listOfNumber[j] = temp;
                    }
                }

            }
            return listOfNumber;
        }
        static void Main(string[] args)
        {
            int[] listOfNumber = {1,2,3,785, 558,102,12,65465465 };
            int[] orderdList = LargestInList(listOfNumber);
            Console.WriteLine(orderdList[0] + " :Its the Largest number");
            Console.WriteLine("List in Descending order);
            for (int a = 0; a < orderdList.Length; a = a + 1)
            {
                Console.WriteLine("" + orderdList[a]);
            
            }
            Console.ReadKey();
        }
    }
}
