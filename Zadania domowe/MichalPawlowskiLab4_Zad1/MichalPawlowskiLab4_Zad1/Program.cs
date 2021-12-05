using System;

namespace MichalPawlowskiLab4_Zad1
{
    class Program
    {
        /// <summary>
        /// Funkcja przelicza podana ocene procentowa z testu na wynik w postaci adekwatnej oceny z przedzialu <2;5.5>
        /// na podstawie skali
        /// <50 prec. - dop,
        /// 50 proc - dst,
        /// 60 proc. - dst+,
        /// 70 proc. - db,
        /// 80 proc. - db+,
        /// 90 proc. - bdb,
        /// 95 proc. - bdb+.
        /// </summary>
        /// <param name="percentageScore">
        /// Zmienna typu double zawierajaca procentowa wartosc oceny z egzaminu
        /// </param>
        /// <returns>
        /// Funckja zwraca wartość oceny z przedzialu <2;5.5> jezeli podany argument do funkcji zostal wprowadzony poprawnie
        /// </returns>
        static void TestScore(double percentageScore)
        {
            if (percentageScore < 0 || percentageScore > 100)
            {
                Console.WriteLine("Wprowadzono niepoprawna wartosc");
            }
            else
            {
                if (percentageScore < 50)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 2");
                }
                else if (percentageScore > 50 && percentageScore < 60)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 3");
                }
                else if (percentageScore > 60 && percentageScore < 70)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 3.5");
                }
                else if (percentageScore > 70 && percentageScore < 80)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 4");
                }
                else if (percentageScore > 80 && percentageScore < 90)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 4.5");
                }
                else if (percentageScore > 90 && percentageScore < 95)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 5");
                }
                else 
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 5.5");
                }
            }
        }

        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Ktora opcje wybierasz:");
                Console.WriteLine("1) Funkcja przeliczajaca ocene procentowa na ocena stopniowana");
                Console.WriteLine("2) Funkcja przeliczajaca ocene procentowa na ocena stopniowana");
                Console.WriteLine("3) Funkcja przeliczajaca ocene procentowa na ocena stopniowana");
                Console.WriteLine();
                Console.WriteLine("0) Wyjscie z programu");

                option = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Podaj wartosc oceny w procentach:");
                        double procentageScore = Convert.ToDouble(Console.ReadLine());
                        TestScore(procentageScore);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                        default:
                    Console.WriteLine("Nieprawidlowa opcja");
                        break;
                }

                Console.Clear();
            } while (option != 0);
        }
    }
}
