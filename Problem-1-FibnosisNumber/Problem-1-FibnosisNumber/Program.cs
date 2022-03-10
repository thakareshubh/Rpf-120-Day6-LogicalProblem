using System;

namespace Problem_1_FibnosisNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number=Convert.ToInt32(Console.ReadLine());
            FibnoNumber p1 = new FibnoNumber();
            p1.Fibno(number);

        }
    }
    public class FibnoNumber
    {
        public void Fibno(int number)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write(n1+" ");
            for(int i = 0; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
