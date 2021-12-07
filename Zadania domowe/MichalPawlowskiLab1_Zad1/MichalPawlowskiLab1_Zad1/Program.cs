using System;

//Zadanie domowe nr 1

namespace MichalPawlowskiLab1_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Komunikat o podaniu imienia i nazwiska 
            Console.WriteLine("Podaj swoje imie i nazwisko: <imie nazwisko>");

            //Pobranie od uzytkownika imienia i nazwiska
            string imieNazwisko = Console.ReadLine();

            //Poproszenie uzytkownika o wpisanie dwoch liczb do kalkulatora
            Console.WriteLine("\n" + imieNazwisko + " wpisz dwie liczby calkowite:");

            //Pobranie pierwszej liczby
            Console.WriteLine("Pierwsza liczba: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Pobranie drugiej liczby
            Console.WriteLine("Druga liczba: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Wypisanie podanych przez uzytkownika liczb
            Console.WriteLine("Wpisales nastepujace liczby: " + firstNumber + " i " + secondNumber);

            //Wynik dodawania
            int addResult = firstNumber + secondNumber;
            Console.WriteLine("Wynik dodawania liczb: " + addResult);

            //Wynik odejmowania
            int subResult = firstNumber - secondNumber;
            Console.WriteLine("Wynik odejmowania liczb: " + subResult);

            //Wynik mnozenia
            int multiResult = firstNumber * secondNumber;
            Console.WriteLine("Wynik mnozenia liczb: " + multiResult);

            //Wynik dzielenia
            double divResult = Convert.ToDouble(firstNumber/secondNumber);
            Console.WriteLine("Wynik dzielnia liczb: " + divResult);

            //Zakonczenie dzialania programu
            Console.WriteLine("Wciśnij dowolny klawisz aby zakonczyc program");
            Console.ReadKey();      
        }
    }
}

//Jeśli chodzi o możliwe ulepszenia do mógłbyś poczytać sobie o wyłapywaniu błędów czyli o blokach try catch
//i sprawić że program odpowiednio by reagował gdy user zamiast liczby poda na przykład tekst.
//Możesz też poczytać o innych sposobach konwersji np metodzie TryParse :D.

//Tak juz bardziej bardziej dodatkowo to możesz poczytać sobie czym jest tabela z kodami ASCII i jak je można użyć i obsłużyć ;)
