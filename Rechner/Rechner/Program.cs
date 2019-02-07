using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;

            int ErstZahl;
            string ErstZeichen;

            int WeitereZahl;
            string WeitereZeichen;

            int Ergebnis;

            Console.Write("Erste Zahl: ");
            Eingabe = Console.ReadLine();
            ErstZahl = Convert.ToInt32(Eingabe);

            Console.Write("+ - * / ");
            Eingabe = Console.ReadLine();
            ErstZeichen = Eingabe;

            Console.Write("Zweite Zahl: ");
            Eingabe = Console.ReadLine();
            WeitereZahl = Convert.ToInt32(Eingabe);

            if (ErstZeichen == "+")
                Ergebnis = ErstZahl + WeitereZahl;
            else if (ErstZeichen == "-")
                Ergebnis = ErstZahl - WeitereZahl;
            else if (ErstZeichen == "*")
                Ergebnis = ErstZahl * WeitereZahl;
            else
                Ergebnis = ErstZahl / WeitereZahl;

            Console.Write("+ - * / = ");
            Eingabe = Console.ReadLine();
            WeitereZeichen = Eingabe;

            while (WeitereZeichen != "=")
            {
                if (WeitereZeichen == "+")
                {
                    Console.Write("Weitere Zahl: ");
                    Eingabe = Console.ReadLine();
                    WeitereZahl = Convert.ToInt32(Eingabe);

                    Ergebnis += WeitereZahl;

                    Console.Write("+ - * / = ");
                    Eingabe = Console.ReadLine();
                    WeitereZeichen = Eingabe;
                }
                else if (WeitereZeichen == "-")
                {
                    Console.Write("Weitere Zahl: ");
                    Eingabe = Console.ReadLine();
                    WeitereZahl = Convert.ToInt32(Eingabe);

                    Ergebnis -= WeitereZahl;

                    Console.Write("+ - * / = ");
                    Eingabe = Console.ReadLine();
                    WeitereZeichen = Eingabe;
                }
                else if (WeitereZeichen == "*")
                {
                    Console.Write("Weitere Zahl: ");
                    Eingabe = Console.ReadLine();
                    WeitereZahl = Convert.ToInt32(Eingabe);

                    Ergebnis *= WeitereZahl;

                    Console.Write("+ - * / = ");
                    Eingabe = Console.ReadLine();
                    WeitereZeichen = Eingabe;
                }
                else if (WeitereZeichen == "/")
                {
                    Console.Write("Weitere Zahl: ");
                    Eingabe = Console.ReadLine();
                    WeitereZahl = Convert.ToInt32(Eingabe);

                    Ergebnis /= WeitereZahl;

                    Console.Write("+ - * / = ");
                    Eingabe = Console.ReadLine();
                    WeitereZeichen = Eingabe;
                }
                else
                {
                    Console.Write("+ - * / = ");
                    Eingabe = Console.ReadLine();
                    WeitereZeichen = Eingabe;
                }
            }

            Console.WriteLine("\n {0}", Ergebnis);
            Console.ReadKey();
        }
    }
}
