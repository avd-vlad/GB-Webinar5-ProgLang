/*-------------------------------------------------------------------------------------------------------------------
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

            Console.Write("Please enter number to check: ");
            int num = GetNumber();

            if(CheckNum(arr,num))
                Console.WriteLine($"Number {num} found in array");
            else
                Console.WriteLine($"Number {num} not found in array");

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min,max+1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine("[" + string.Join(" ", numbers.Select(x => x)) + "]");
        static bool CheckNum(int[] arr, int num)
        {
            foreach (int x in arr)
            {
                if(x==num)
                    return true;
            }
            return false;
        }
    }
}
