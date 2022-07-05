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
                string[] arr = new string [number];

                return arr;
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

        static int CheckArray (string[] arr)

        {
            int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                 if (arr[i].Length < 4) count++;
                 Console.Write (Arr[i] + " ");   
                }
            return count;
        }

         static string[] FillResult (string[] arrSource, string[] massRes)
        {
            for (int i = 0, j = 0; i < arrSource.Length; i++)
                {
                 if (arrSource[i].Length < 4) 
                 {
                     massRes[j] = arrSource[i];
                     j++;
                 };   
                }
        
                return massRes;
        }

        static void PrintArray (string[] arrSource, string[] massRes)

        {
                Console.Write("[ ");
                 for (int i = 0; i < arrSource.Length; i++)
                {
                    Console.Write ("\"" + arrSource[i] + "\"" + " ");   
                }
                Console.Write("] -> [ ");

                for (int j = 0; j < massRes.Length; j++)
                {
                    Console.Write ("\"" + massRes[j] + "\"" + " ");   
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
                Console.WriteLine();
                     Console.WriteLine("Нажмите Enter для получения результата ");
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

