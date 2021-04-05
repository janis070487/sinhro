using System;

namespace uzdevums1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            Console.WriteLine("Ievadi skaitli 1");
            a = Console.ReadLine();
            Console.WriteLine("Ievadi skaitli 2");
            b = Console.ReadLine();

            double aa = Convert.ToDouble(a);
            double bb = Convert.ToDouble(b);
            double sum = (aa + bb) / 2;

            Console.WriteLine("Vidējais aritmētiskais = " + sum);

            Console.ReadLine();
        }
    }
}
