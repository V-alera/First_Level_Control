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
        


        static void Main(string[] args)
        {
            Console.Clear();
                
                Console.Write("Введите количество элементов массива: ");
                int num = int.Parse(Console.ReadLine());

                string[] table = {}, res= {};
                               
                table = MassInit (num);
                
        }        
    }
}

