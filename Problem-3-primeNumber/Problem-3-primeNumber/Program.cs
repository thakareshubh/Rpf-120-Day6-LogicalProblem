using System;

namespace Problem_3_primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number=Convert.ToInt32(Console.ReadLine());
            PrimeNumber p1 = new PrimeNumber();
            p1.Prime(number);
        }
    }
    public class PrimeNumber
    {
        public void Prime(int number)
        {
            int temp;
            int i = 2;
            while(i < number)
            {
                temp = number % i;
                if(temp == 0)
                {
                    break;
                }
                
                i++;
            }
            if(i== number)
            {
                Console.WriteLine(number + " is prime number");
            }
            else
            {
                Console.WriteLine(number + " is not prime number");
            }
        }
    }
}
