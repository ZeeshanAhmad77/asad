using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question04
{
    class Program
    {


         static void occurInList(int number ,int[] listOfNumber) 
        {
            int i = 0;
            
            while(i<listOfNumber.Length)
            {
                if (listOfNumber[i] == number)
                {
                    Console.WriteLine(number + " occur in the list");
                    break;
                }
               
                   
                    
                
                i = i + 1;
            }
            Console.WriteLine(number + "  : Don't occur in the list");
        }
        
        static void Main(string[] args)
        {
            int[] listofNumber = { 10, 20, 30, 40 };
            int number = 11;
         
             occurInList(number, listofNumber);
            Console.ReadKey();
        }
    }
}
