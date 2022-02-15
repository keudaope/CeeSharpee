using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            String luku1, luku2;
            int summa;
            Console.Write("Anna 1. luku: ");
            luku1 = Console.ReadLine();
            Console.Write("Anna 2. luku: ");
            luku2 = Console.ReadLine();
            summa = Int32.Parse(luku1) + Int32.Parse(luku2);
            Console.WriteLine(summa);
            Console.ReadLine();
        }
    }
}
