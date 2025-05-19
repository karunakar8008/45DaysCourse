using System;
namespace Factorial
{
    public class Factorial
    {
        public void fibanocci(int num)
        {

                int temp1 = 0;
                int temp2 = 1;
            System.Console.Write($"The fibanocci of given number {num}: ");
            for (int i = 0; i < num; i++)
            {
                
                System.Console.Write(temp1 + " ");
                int nextNum = temp1 + temp2;
                temp1 = temp2;
                temp2 = nextNum;
            }
        }

        public void factorial(int num)
        {
            int temp = 1;
            for (int i = 1; i <= num; i++)
            {
                temp = temp * i;
            }
            System.Console.WriteLine($"The factorial of given number {num}: {temp}");
        }
        public static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            Factorial f = new Factorial();
            f.factorial(num);
            f.fibanocci(num);

        }
    }
}