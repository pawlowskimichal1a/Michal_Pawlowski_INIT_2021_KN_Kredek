using System;

namespace PatrykGanczarekLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());



            //int c = 123 + 5;

            // \n \r - znak końca linii

            Console.WriteLine($"Liczba pierwsza to: {number}");
            Console.WriteLine($"Liczba druga to: {number2}");
            Console.WriteLine($"Wynik odejmowania to: {number - number2}");


            Console.ReadKey();

        }
    }
}
