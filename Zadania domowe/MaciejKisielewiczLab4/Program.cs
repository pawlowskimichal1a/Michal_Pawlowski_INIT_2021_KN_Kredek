using System;
using System.Collections.Generic;
using System.Linq;

namespace MaciejKisielewiczLab4
{
    class Program
    {
        /// <summary>
        /// Funkcja która gratuluje użytkownikowi
        /// </summary>
        static void Congratulations(string name = "Grzegorz", int age = -1)
        {
            Console.WriteLine("Gratulacje " + name +  "! Napisałeś pierwszą funkcję! Masz " + age + " lat." );
        }

        /// <summary>
        /// Funkcja obliczająca długość okręgu
        /// </summary>
        /// <param name="radius">Promień okręgu</param>
        static void CalculateCircleLength(double radius)
        {
            Console.WriteLine($"Długość okręgu to {Math.Round(2*radius*Math.PI,2)}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        static int Add(double x, int y, int z)
        {
            int result = (int)x + y + z;
            return result;
        }

        static bool PasswordVerification(string password)
        {
            if(password == "asdfghjk")
            {
                return true;
            }

            return false;
        }

        static int RecursiveDisplay(int a)
        {
            if(a == 1)
            {
                return a;
            }

            Console.WriteLine(a);

            return RecursiveDisplay(a - 1);
        }

        static int CalculateSum(int start, int stop)
        {
            if(start == stop)
            {
                return stop;
            }

            Console.WriteLine(stop);

            return stop + CalculateSum(start,stop - 1);
        }

        static List<string> ExerciseThree(List<string> fruits)
        {
            var result = fruits.Where(fruit => fruit.StartsWith("L") && fruit.Length < 6 ).OrderBy(fruit => fruit).ToList();

            return result;
        }

        static void Main(string[] args)
        {
            Congratulations("Maciej",21);
            Congratulations("Kasia");
            Congratulations();
            CalculateCircleLength(3);
            Console.WriteLine(Add(2,5));
            Console.WriteLine(Add(2,5,7));
            Console.WriteLine(PasswordVerification("asdfghjk"));
            RecursiveDisplay(10);
            Console.WriteLine(CalculateSum(1,10));

            Console.WriteLine("LINQ \n");

            int[] scores = new int[] {97, 60, 10, 20, 71, 80,85, 100};

            var scoresQuery = (from score in scores where score > 70 select score).ToList();

            foreach(int score in scoresQuery)
            {
                Console.WriteLine(score);
            }

            var scoresQueryMethodBased = scores.Where( score => score > 70).OrderBy(score => score).ToList();

            foreach(int score in scoresQueryMethodBased)
            {
                Console.WriteLine(score);
            }
            
            var wordsA = new string[] { "apple", "peach", "blueberry" };

            var wordsB = new string[] { "apple", "peach", "cherry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine(match);

            List<int> testList = Enumerable.Range(0,1000).ToList();

            var max = testList.Max();
            var min = testList.Min();
            var average = testList.Average();
            var firstOrDefault = testList.FirstOrDefault(number => number > 99);

            List<string> list = new List<string>() {"Liczi","Laskowiec","Limonka","Jabłko"};

            var resultList = ExerciseThree(list);

            foreach(string fruit in resultList)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
