using System;
namespace Palindrome
{
    public class Palindrome
    {
        public void reverseNumber(int num)
        {
            int actual = num;
            int temp=0;
            while (num > 0) //k = 456;
            {
                temp = temp * 10 + num % 10;

                num = num / 10;
            }
            if (temp == actual)
            {
                System.Console.WriteLine("Palindrome");
            }
            else
            {
                System.Console.WriteLine("Not a palindrome");
            }
        }


        public void reverseString(string s)
        {
            string temp = "";
            char[] ch = s.ToCharArray();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                temp += ch[i];
            }

            if (temp == s)
            {
                System.Console.WriteLine("Palindrome");
            }
            else
            {
                System.Console.WriteLine("Not a palindorme");
            }

        }
        public static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            System.Console.WriteLine("Please enter the string to check whether its a palindorme or not");
            string s = Console.ReadLine().ToLower();
            
            if (int.TryParse(s, out int num))
            {
                p.reverseNumber(num);
            }
            else
            {
                p.reverseString(s);
            }

        }
    }
}