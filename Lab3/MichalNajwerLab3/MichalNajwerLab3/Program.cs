using System;
using System.Collections.Generic;

namespace MichalNajwerLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // instruckcje warunkowe
            if (true)
            {
                Console.WriteLine("W ifie true");
            }

            if (false)
            {
                Console.WriteLine("W ifie false");
            }

            bool test = true;

            if (!test)
            {
                Console.WriteLine("if bool true");
                Console.WriteLine("druga linia");
            }
            else
            {
                Console.WriteLine("w elsie");
            }
            

            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"{a} jest wieksze");
            else
                Console.WriteLine($"{b} jest wieksze");
            

            int a2 = Int32.Parse(Console.ReadLine());
            int b2= Int32.Parse(Console.ReadLine());

            if (a2 == b2)
                Console.WriteLine("Liczby sa rowne");
            else
                Console.WriteLine("Liczby sa rozne");
            

            int a3 = Int32.Parse(Console.ReadLine());
            int b3 = Int32.Parse(Console.ReadLine());

            if (a3 > b3 && a3 > 10)
            {
                Console.WriteLine("a jest wieksze od b i wieksze od 10");
            }
            else
            {
                Console.WriteLine("jeden z warunkow nie zostal spelniony");
            }
            

            int a4 = Int32.Parse(Console.ReadLine());
            int b4 = Int32.Parse(Console.ReadLine());

            if(a4 >= b4 || b4 == 50)
            {
                Console.WriteLine("przynajmniej jeden warunek zostal spelniony");
            }
            else
            {
                Console.WriteLine("oba warunki nie spelnione");
            }
            

            //Switch case

            int a5 = 5;

            if(a5 == 10)
            {
                Console.WriteLine("pierwsze if");
            }
            else if(a5 == 15)
            {
                Console.WriteLine("drugi if");
            }
            else if(a5 == 20)
            {
                Console.WriteLine("trzeci if");
            }
            else
            {
                Console.WriteLine("ostatni else");
            }


            switch (a5)
            {
                case 10:
                    Console.WriteLine("piec");
                    break;
                case 15:
                    Console.WriteLine("pietnascie");
                    break;
                case 20:
                    Console.WriteLine("dwadziescia");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            

            //Petle

            int counter = 5;

            while(counter > 5)
            {
                Console.WriteLine(counter);
            }

            Console.WriteLine();
            counter = 5;

            do
            {
                Console.WriteLine(counter);
            } while (counter > 5);
            
            
            int x = Int32.Parse(Console.ReadLine());

            for(int i = 0; i <= x; i++)
            {
                if (i >= 5)
                    continue;

                if (i % 2 == 0)
                    Console.WriteLine($"{i} jest parzyste");
                else
                    Console.WriteLine($"{i} jest nieparzyste");
            }
            

            //Tablice 

            int[] tab = { 10, 3, -1, 20 };
            int[] tab2 = new int[10];

            tab2[2] = 100;
            tab2[9] = -10;
            
            foreach(int item in tab)
            {
                Console.WriteLine(item);
            }

            object[] tab3 = { true, 10, 3.3, "napis" };
            
            foreach(object item in tab3)
            {
                Console.WriteLine(item);
            }
            

            int[][] matrix = new int[3][];
            matrix[0] = new int[5];
            matrix[1] = new int[2];
            matrix[2] = new int[3];

            matrix[0][2] = 5;

            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
            

            //Listy

            List<string> list = new List<string>() { "pies", "kot" };

            list.Add("tygrys");

            list.Insert(1, "kon");

            list.RemoveAt(0);

            list.ForEach(Console.WriteLine);
            

            List<int> list2 = new List<int>() { 10, -1, 2, 6, 10, 0 };

            list2.ForEach(Console.WriteLine);

            list2.Sort();
            list2.Reverse();

            Console.WriteLine();
            list2.ForEach(Console.WriteLine);
            
            //Kolejki

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("kot");
            queue.Enqueue("pies");
            queue.Enqueue("kon");

            foreach(string item in queue)
            {
                queue.Dequeue();
            }
            
            Console.WriteLine();

            //Stosy

            Stack<string> stack = new Stack<string>();
            stack.Push("kot");
            stack.Push("pies");
            stack.Push("kon");

            for (int i = 0; i < 3; i++)
                Console.WriteLine(stack.Pop());

            
            //Słowniki

            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("azor", 10);
            dict.Add("nero", 6);
            dict.Add("fafik", 1);

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            }

            dict.Remove("nero");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} klucz, {item.Value} wartosc");
            }
            
        }
    }
}
