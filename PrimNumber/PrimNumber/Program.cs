using System;

namespace PrimeNumber
{
    public class Day3
    {
        static int count;
        public static void Main(string[] args)
        {

            for (int i = 2; i < 100; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
               
                }
                     if (count<1)
                {
                    System.Console.Write(i+" ");
                }
                
                count = 0;
            }
            
        }
    
    }
}