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
        /// 
        /// <returns>
        /// Funckja zwraca wartość oceny z przedzialu <2;5.5> jezeli podany argument do funkcji zostal wprowadzony poprawnie
        /// </returns>
        static void TestScore()
        {
          Console.Clear();
          Console.WriteLine("Podaj wartosc oceny w procentach:");
          double percentageScore = Convert.ToDouble(Console.ReadLine());

          if (percentageScore < 0 || percentageScore > 100)
            {
                int choice = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadzono niepoprawna wartosc");
                    Console.WriteLine("Co chcialbys wykonac:");
                    Console.WriteLine("1) Wpisac ponownie wartosc testu");
                    Console.WriteLine();
                    Console.WriteLine("0) Wyjsc z funkcji");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            TestScore();
                            break;
                        case 0:
                            break;
                    }

                } while (choice != 0 && choice != 1);
            } 
            else
            {
                Console.Clear();
                if (percentageScore < 50)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 2");
                    Console.ReadKey();
                }
                else if (percentageScore > 50 && percentageScore < 60)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 3");
                    Console.ReadKey();
                }
                else if (percentageScore > 60 && percentageScore < 70)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 3.5");
                    Console.ReadKey();
                }
                else if (percentageScore > 70 && percentageScore < 80)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 4");
                    Console.ReadKey();
                }
                else if (percentageScore > 80 && percentageScore < 90)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 4.5");
                    Console.ReadKey();
                }
                else if (percentageScore > 90 && percentageScore < 95)
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 5");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("Twoja ocena z egzaminu to 5.5");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Funkcja przyjmuje jako argument wartosc dochodu osoby i wylicza podatek dochodowy
        /// ktory ma dana osoba zaplacic. Granice podatkowe:
        /// 0-85 528 - podatek 17%
        /// 85 528 - 1 000 000 - podatek 17% za kwtote 85 528 i podatek 32% za kazda zlotowke, ktora powoduje przekroczenie progru 85 528 zl
        /// 1 000 000 + - podatek 36% za kazda zlotowke, ktora powoduje przekroczenie dochodu o 1zl powyzej 1 mln
        /// </summary>
        /// 
        /// <param name="income">
        /// Wartosc dochodu
        /// </param>
        /// 
        /// <returns>
        /// Funkcja zwraca wartosc naleznego podatku dochodowego
        /// </returns>
        static double IncomeTax(double income)
        {
            double tax = 0;

            Console.Clear();

            if (income<=0)
            {
                Console.WriteLine("Nie odprowadzaj podatku od takiej kwoty, bo umrzesz");
            }
            else if (income <= 85528 && income>0)
            {
                tax = 85528 * 0.17;
            }
            else if (income > 85528 && income <= 1000000)
            {
                tax = 85528 * 0.17 + (income - 85528) * 0.32;
            }
            else
            {
                tax = 85528 * 0.17 + (1000000 - 85528) * 0.32 + (income - 1000000) * 0.36;
            }

            return Math.Round(tax,2);
        }

        /// <summary>
        /// Cztery podstawowe funkcje kalkulatora: dodawanie, odejmowanie, mnozenie, dzielenie
        /// </summary>
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static double Substract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a/b;
        }
        
        /// <summary>
        /// Funckja kalkulator obslugujaca powyzsze cztery funkcje, odzwierciedlajace cztery podstawowe dzialania matematyczne
        /// </summary>
        static void Calculator()
        {
            int flag = 2;
            double a = 0;
            double b = 0;
           
            Console.Clear();
            Console.WriteLine("Witamy w kalkulatorze");
            Console.WriteLine("Kliknij dowolny klawisz aby rozpoczac");

            do
            {
                if (flag == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Podaj pierwsza liczbe");
                    a = Convert.ToDouble(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine("Podaj druga liczbe");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Wpisz + jezeli chcesz dodac liczby");
                Console.WriteLine("Wpisz - jezeli chcesz odjac liczby");
                Console.WriteLine("Wpisz * jezeli chcesz pomnozyc liczby");
                Console.WriteLine("Wpisz / jezeli chcesz podzielic liczby");
                Console.WriteLine("Podaj znak dzialania miedzy liczba pierwsza a druga: ");
                char operationSymbol = Convert.ToChar(Console.ReadLine());

                switch (operationSymbol)
                {
                    case '+':
                        a = Sum(a, b);
                        break;
                    case '-':
                        a = Substract(a, b);
                        break;
                    case '*':
                        a = Multiply(a, b);
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Nie mozna dzielic przez 0");
                            a = 0;
                            flag = 0;
                            Console.ReadKey();
                            break;
                        }
                        a = Divide(a, b);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Podales nieporpawny symbol dzialania matematycznego");
                        flag = 0;
                        break;
                }

                Console.Clear();
                Console.WriteLine("Aktualny wynik to: " + a);
                Console.WriteLine();
                Console.WriteLine("Co chcesz teraz wykonac: ");
                Console.WriteLine("1) Kontynuowac dzialania na aktualnym wyniku");
                Console.WriteLine("2) Rozpoczac nowe dzialanie");
                Console.WriteLine();
                Console.WriteLine("0) Wyjsc z kalkulatora");

                do
                {
                    flag = Convert.ToInt32(Console.ReadLine());
                } while (flag != 0 && flag != 1 && flag != 2);
                
            } while (flag != 0);

        }

        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ktora opcje wybierasz:");
                Console.WriteLine("1) Funkcja przeliczajaca ocene procentowa na ocena stopniowana");
                Console.WriteLine("2) Funkcja obliczajaca podatek dochodowy");
                Console.WriteLine("3) Kalkulator");
                Console.WriteLine();
                Console.WriteLine("0) Wyjscie z programu");

                option = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        TestScore();
                        break;
                    case 2:
                        Console.WriteLine("Podaj swoj roczny dochod");
                        double income = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Podatek, ktory musisz odprowadzic wynosi: " + IncomeTax(income));
                        Console.ReadKey();
                        break;
                    case 3:
                        Calculator();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Nieprawidlowa opcja");
                        break;
                }
            } while (option != 0);
        }
    }
}
