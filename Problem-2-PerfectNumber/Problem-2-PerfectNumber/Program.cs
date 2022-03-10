using System;

namespace Problem_2_PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number =Convert.ToInt32(Console.ReadLine());
            PerfectNumber p1 = new PerfectNumber();
            p1.Perfect(number);
        }
    }
    public class PerfectNumber
    {
        public void Perfect(int number)
        {
            int temp = 0;
            for(int i = 1; i < number; i++)
            {
                if(number%i==0)
                {
                    temp=temp+i;
                }
                
            }
            if(temp==number)
            {
                Console.WriteLine(number + " is a perfect number");
            }
            else
            {
                Console.WriteLine(number + " is not perfect number");
            }
        }
    }
}
