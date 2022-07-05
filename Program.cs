/* 
Контрольная работа: написать программу, которая из имеющегося массива строк формирует массив строк, 
длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
*/
using System;

namespace HW6_Seminar6_Task41_programming_languages
{
    class Program
    {
        static string[] MassInit (int number)

        {
                string[] Arr = new string [number];

                return Arr;
        }
        
        static string[] FillArray (string[] Arr, int number)
        {
            for (int i = 0; i < number; i++)
                {
                    Console.Write ($"Элемент {i}: ");
                    Arr[i] = Console.ReadLine();
                }
        
                return Arr;
        }

        static int CheckArray (string[] Arr)

        {
            int count = 0;
                for (int i = 0; i < Arr.Length; i++)
                {
                 if (Arr[i].Length < 4) count++;
                 Console.Write (Arr[i] + " ");   
                }
            return count;
        }

         static string[] FillResult (string[] ArrSource, string[] MassRes)
        {
            for (int i = 0, j = 0; i < ArrSource.Length; i++)
                {
                 if (ArrSource[i].Length < 4) 
                 {
                     MassRes[j] = ArrSource[i];
                     j++;
                 };   
                }
        
                return MassRes;
        }

        static void PrintArray (string[] ArrSource, string[] MassRes)

        {
                Console.Write("[ ");
                 for (int i = 0; i < ArrSource.Length; i++)
                {
                    Console.Write ("\"" + ArrSource[i] + "\"" + " ");   
                }
                Console.Write("] -> [ ");

                for (int j = 0; j < MassRes.Length; j++)
                {
                    Console.Write ("\"" + MassRes[j] + "\"" + " ");   
                }
                Console.Write("]");
        }

        static void Main(string[] args)
        {
            Console.Clear();
                
                    Console.Write("Введите количество элементов массива: ");
                int num = int.Parse(Console.ReadLine());

                string[] table = {}, res= {};
                               
                table = MassInit (num);

                Console.WriteLine();
                    Console.WriteLine($"Заполните массив элементами в количестве: {num}");
                Console.WriteLine();

                table = FillArray (table, num);
                
                Console.WriteLine();
                     Console.WriteLine("Исходный вид: ");
                int count = CheckArray (table);

                Console.WriteLine();
                     Console.WriteLine($"Количество строк с символами 3 и меньше: {count}");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine();
                res = MassInit (count);
                res = FillResult (table, res);

                Console.WriteLine();
                PrintArray (table, res);
                Console.WriteLine();
        }        
    }
}

