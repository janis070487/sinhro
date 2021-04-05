using System;
//ok
using System.Globalization;
namespace uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo nfi = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };
            string a;
            string b;

            Console.WriteLine("Ievadi skaitli 1");
            a = Console.ReadLine();
            Console.WriteLine("Ievadi skaitli 2");
            b = Console.ReadLine();

            try
            {
                double aa = double.Parse(a, nfi);
                double bb = double.Parse(b, nfi);
                double sum = (aa + bb) / 2;

                Console.WriteLine("Vidējais aritmētiskais = " + sum);
            }
            catch (Exception)
            {
                Console.WriteLine("ievadīts nekorekts skaitlis!!!");
            }


            Console.ReadLine();

        }
    }
}
s
