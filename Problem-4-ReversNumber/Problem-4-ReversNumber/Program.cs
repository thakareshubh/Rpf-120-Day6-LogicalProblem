using System;

namespace Problem_4_ReversNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter more than four digit number");
            int number = Convert.ToInt32(Console.ReadLine());
            ReverseNumber p1 = new ReverseNumber();
            p1.Reverse(number);
        }
    }

    public class ReverseNumber
    {
        public void Reverse(int number)
        {
            int baki,  revers=0;
            while(number!=0)
            {
                baki = number % 10;
                revers = revers * 10 + baki;
                number = number / 10;
            }
            Console.WriteLine(revers);
        }
    }
}
