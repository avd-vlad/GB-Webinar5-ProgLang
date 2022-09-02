/*-------------------------------------------------------------------------------------------------------------------
Напишите программу для замены элементов массива: положительные элементы замените на соответствующие отрицательные, 
и наоборот.
-------------------------------------------------------------------------------------------------------------------*/

using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Please enter aray size: ");
            int size = GetNumber();

            Console.Write("Please enter min range: ");
            int min = GetNumber();

            Console.Write("Please enter max range: ");
            int max = GetNumber();

            int[] arr=CreateArray(size, min, max);
            PrintArray(arr);
            int[] resArr=Invert(arr);
            PrintArray(resArr);

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min,max+1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine("[" + string.Join(" ", numbers.Select(x => x)) + "]");
        static int[] Invert(int[]num) => num.Select(x=>-x).ToArray();
    }
}


