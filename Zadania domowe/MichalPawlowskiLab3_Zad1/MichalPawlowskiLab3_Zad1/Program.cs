using System;
using System.Collections.Generic;

namespace MichalPawlowskiLab3_Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracja dwoch list przechowywujacych kolejno wyraz do odgadniecia i odgadniete litery
            List<char> lettersToGuess = new List<char>();
            List<char> lettersGuessed = new List<char>();
            int chances = 3;

            //poproszenie uzytkownika o wpisanie slowa do odgadniecia
            Console.WriteLine("Podaj slowo, ktore ma zostac odgadniete:");
            string wordToGuess = Console.ReadLine();

            //petla przepisujaca pobrany wyraz do listy litera po literze i uzupelniajaca druga liste o #
            for (int index = 0; index < wordToGuess.Length; index++)
            {
                lettersToGuess.Add(wordToGuess[index]);
                lettersGuessed.Add('#');
            }

            //glowna petla programu
            do
            {
                bool letterFound = false;
                Console.Clear();

                //wyswietlenie dotychczas odgadnietych liter z szukanego wyrazu
                Console.WriteLine("Twoje odgadnięte do tej pory litery w szukanym wyrazie:");
                lettersGuessed.ForEach(Console.Write);

                Console.WriteLine($"\nPozostalo Ci jeszcze {chances} mozliwosci bledu.");

                //pobranie od uzytkownika litery do wyszukania w szukanmym wyrazie
                Console.WriteLine("\n\nPodaj litere, ktora chcesz odgadnac w wyrazie:");
                char letter = Console.ReadLine()[0];
                
                //petla sprawdzajaca wystepowanie podanej przez uzytkownika litery w wyrazie szukanym
                for(int index = 0; index<lettersToGuess.Count; index++)
                {
                    if(lettersToGuess[index] == letter)
                    {
                        //jezeli dana liczba zostala odnaleziona to wpisz ja do listy odnalezionych liter
                        lettersGuessed[index] = lettersToGuess[index];
                        letterFound = true;
                    }
                }

                if(letterFound == false)
                {
                        //w przeciwnym przypadku odejmij jedna z dostepnych mozliwosci bledu
                        chances--;
                }

            // zakoncz petle jezeli zostaly odgadniete wszystkie litery
            } while (lettersGuessed.Contains('#') && chances!=0 );

            Console.Clear();

            if (lettersGuessed.Contains('#'))
            {
                Console.WriteLine("Niestety przegrales");
            }
            else
            {
                Console.WriteLine("Brawo odgadles slowo:");
                lettersGuessed.ForEach(Console.Write);
            }

            Console.WriteLine("\n\nKliknij dowolny klawisz aby wyjsc z programu");
            Console.ReadKey();
        }
    }
}
