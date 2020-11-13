
using System;

namespace Esercizio2_Gruppo
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i numeri che vuoi classificare");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            ClassificazioneNumeri(x, y);
            Console.ReadKey();
        }
        static double ClassificazioneNumeri(double x, double y)
        {

            for (; ; )//for infinito
            {
                if (x > y)
                {
                    Console.WriteLine("{0} > {1}, inserisci un'altro numero per confrontarlo con {2}", x, y, x);
                    y = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    if (x < y)
                    {
                        Console.WriteLine("{0} > {1}, inserisci un'altro numero per confrontarlo con {2}", y, x, y);
                        x = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("{0} = {1}, inserisci un'altro numero per confrontarlo con {2}", y, x, y);
                        x = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
        }
    }
}

