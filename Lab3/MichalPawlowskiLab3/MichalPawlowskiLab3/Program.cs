using System;
using System.Collections.Generic;
namespace MichalPawlowskiLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////znalezc najwieksza i wyswietlic ja na ekranie 
            //int a = Int32.Parse(Console.ReadLine());
            //int b = Int32.Parse(Console.ReadLine());
            //int c = Int32.Parse(Console.ReadLine());
            //int theHighest = 0;

            //if (a>b && a>c)
            //{
            //    theHighest = a;
            //}
            //if (b > a && b > c)
            //{
            //    theHighest = b;
            //}
            //if (c > a && c > b)
            //{
            //    theHighest = c;
            //}

            //Console.WriteLine($"Najwieksza liczba to {theHighest}");
            //Console.ReadKey();

            //int d = 20;

            //switch (d)
            //{
            //    case 5:
            //        Console.WriteLine("piec");
            //        break;
            //    case 15:
            //        Console.WriteLine("pietnascie");
            //        break;
            //    case 20:
            //        Console.WriteLine("dwadziescia");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}

            //int counter = 5;

            //while(counter>5)
            //{
            //    Console.WriteLine(counter);
            //}

            //do
            //{
            //    Console.WriteLine(counter);
            //} while (counter > 5);

            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Struktury danych

            //deklaracja tablicy
            //int[] tab = { 10, 3, -1, 20 };
            //int[] tab2 = new int[10];

            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.WriteLine(tab2[i]);
            //}

            //foreach(int item in tab) //przechodzi po każdym elemencie struktury
            //{
            //    Console.WriteLine(item);
            //}

            //object[] tab3 = { true, 10, 3.3, "napis" };

            //foreach (object item in tab3) //przechodzi po każdym elemencie struktury
            //{
            //    Console.WriteLine(item);
            //}

            //int[][] matrix = new int[3][];
            //matrix[0] = new int[5];
            //matrix[1] = new int[2];
            //matrix[2] = new int[3];

            //matrix[0][4] = 5;

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j=0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            // Lista danych złozonych

            //List<string> list = new List<string>() { "pies", "kot" };

            //list.Add("tygrys");
            //list.Insert(1, "kon");
            //list.RemoveAt(0);

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.ForEach(Console.WriteLine);

            //List<int> list2 = new List<int>() { 10, -1, 2, 6, 10, 0 };

            //list2.ForEach(Console.WriteLine);

            //list2.Sort();
            //list2.Reverse();

            //Console.WriteLine();
            //list2.ForEach(Console.WriteLine);

            ////Kolejka
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("kot");
            //queue.Enqueue("pies");
            //queue.Enqueue("kon");

            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            ////Stos
            //Stack<string> stack = new Stack<string>();
            //stack.Push("kot");
            //stack.Push("pies");
            //stack.Push("kon");

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            ////Slownik
            //Dictionary<string, int> dict = new Dictionary<string, int>();

            //dict.Add("azor", 10);
            //dict.Add("nero", 6);
            //dict.Add("rafik", 1);

            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            //}

            //Console.WriteLine();

            //dict.Remove("nero");
            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            //}
        }
    }
}
