using System;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;
            int RechenOperation = 0;
            int Ergebnis = 0;

            string Titel = "Minirechner";

            for (int i = 0; i < (Console.WindowWidth - Titel.Length) / 2; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(Titel);
            Console.WriteLine();

            Console.WriteLine("Bitte geben Sie die erste zahl ein:");
            Zahl1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Bitte geben sie die zweite Zahl ein:");
            Zahl2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Bitte wählen Sie eine RechenOperation [1 Addieren]:");
            RechenOperation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            for (int i = 0; i < (Console.WindowWidth - Titel.Length) / 2; i++)
            {
                Console.Write(" ");
            }

            Console.Write(Titel);
            Console.WriteLine();

            switch (RechenOperation)
            {
                case 1:

                    Ergebnis = Addieren(Zahl1, Zahl2);

                    Console.WriteLine(Zahl1 + " + " + Zahl2 + " = " + Ergebnis);

                    break;

                case 2:

                    Ergebnis = Subtrahieren(Zahl1, Zahl2);

                    Console.WriteLine(Zahl1 + " - " + Zahl2 + " = " + Ergebnis);

                    break;

                case 3:

                    Ergebnis = Multiplizieren(Zahl1, Zahl2);

                    Console.WriteLine(Zahl1 + " * " + Zahl2 + " = " + Ergebnis);

                    break;

            }


            Console.ReadKey();
        }

        // Metohden

        static int Addieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 + zahl2;
            return Lösung;
        }

        static int Subtrahieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 - zahl2;
            return Lösung;
        }

        static int Multiplizieren(int zahl1, int zahl2)
        {
            int Lösung = zahl1 * zahl2;
            return Lösung;
        }
    }

}

