using System;



namespace Demobhagi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 400 == 0)
            {
                Console.WriteLine("leap year");

            }
            else if (a % 100 == 0)
                Console.WriteLine("not leap year");
            else if (a % 4 == 0)
            {
                Console.WriteLine("leap year");
            }

        }
    }
}