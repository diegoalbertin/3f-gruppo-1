//author: albertin, di lena, ferrari,donini,gabrieli
//controlla se i numeri positivi inseriti dall'utente sono primi
using System;

namespace gruppo_1_es_1
{
    class Program
    {
        //nizializzo le variabili
        static int x;
        static double y;
        static double n;
        static int z;
        static int w;
        static void Main(string[] args)
        {
            //inserisco la variabile x
            Console.WriteLine("inserisci x");
            x = Convert.ToInt32(Console.ReadLine());
            //controllo del valore di x
            if (x <= 0)
            {
                //se x è >= 0 chiamo la prima funzione per farlosreinserire fino a quando non viene posto x >0
                negativo(x);
                numeroPrimo(x, y, n, z, w);
            }
            else
            {
                numeroPrimo(x, y, n, z, w);
            }
            Console.ReadKey();
        }
        static int negativo(int x)
        {
            while (x <= 0)
            {
                Console.WriteLine("inserisci un valore positivo");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" x vale {0}", x);
            }
            w = x;
            return w;
        }
        //funzione per controllare se x è un numero primo
        /*un numero primo è un numero divisibile solo per 1 e per se stesso, 
         * perciò avrà solo due divisioni con numeri pari o minori di esso che daranno resto 0*/
        static double numeroPrimo(int x, double y, double n, int z, int w)
        {
            y = 1;
            z = 0;
            /*divisione in due casi:
             1-se la prima x inserita è positiva
             2-se la prima x inserita è negativa*/
            if (x > 0)
            {
                while (y <= x)
                {
                    n = x % y;
                    if (n == 0)
                    {
                        Console.WriteLine("{0}:{1} da resto {2}", x, y, n);
                        z++;
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} da resto {2}", x, y, n);
                    }
                    y++;
                }
                if (z == 2)
                {
                    Console.WriteLine("il numero {0} e' primo", x);
                }
                else
                {
                    Console.WriteLine("il numero {0} non e' primo", x);
                }
            }
            else
            {
                while (y <= w)
                {
                    n = w % y;
                    if (n == 0)
                    {
                        Console.WriteLine("{0}:{1} da resto {2}", w, y, n);
                        z++;
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} da resto {2}", w, y, n);
                    }
                    y++;
                }
                if (z == 2)
                {
                    Console.WriteLine("il numero {0} e' primo", w);
                }
                else
                {
                    Console.WriteLine("il numero {0} non e' primo", w);
                }

            }
            return n;
        }
    }
}