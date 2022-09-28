using System;

namespace Question07
{
    class Program
    {
        static int[] oddPosition(int[] listOfItem)
        {
            int size= listOfItem.Length;
            int oddSize;
            int counterOdd = 1;
            int counterEven=0;
            if (size%2==0)
            {
                oddSize = size / 2;
            }
            else
            {
                oddSize = (size / 2)+1;
       
            }
            int[] oddArray = new int[oddSize];
            for(int i=0;i<oddSize;i=i+1)
            {
                if (oddSize % 2 == 0)
                {
                    
                    oddArray[i] = listOfItem[counterEven];
                    counterEven = counterEven + 2;
                    if (counterEven >= size)
                    { counterEven = size - 1; }
                }
                else
                {
                    
                    oddArray[i] = listOfItem[counterOdd];
                    counterOdd = counterOdd + 2;
                    if (counterOdd >= size)
                    { counterOdd = size - 1; }

                }
            }
            return oddArray;
        }
        static void Main(string[] args)
        {
            int[] listOfItem = { 136,1, 45, 8, 1, 7, 6,7,8,0,9};
            int[] listOfOddPostion=oddPosition(listOfItem);
            for(int i=0;i< listOfOddPostion.Length;i=i+1)
            {
                Console.Write("  "+listOfOddPostion[i]);
            }
          
        }
    }
}
