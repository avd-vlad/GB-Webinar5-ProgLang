/*-------------------------------------------------------------------------------------------------------------------
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

            PrintArray(ShrinkArray(arr));
        }
        static Random rd => new Random();
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min,max+1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine("[" + string.Join(" ", numbers.Select(x => x)) + "]");
        static int[] ShrinkArray(int[] arr)
        {
            int size = arr.Length/2+arr.Length%2;
            int[] newArr = new int[size];
            for (int i=0; i<size; i++)
                if(i!=arr.Length-1-i)
                    newArr[i] = arr[i]*arr[arr.Length-1-i];
                else
                    newArr[i] = arr[arr.Length-1-i];
            return newArr;
        }
        //static int[] ShrinkArr(int[] arr) => arr.Aggregate(0, (a,x) => a+=(x>=min&&x<=max)?1:0);
        
    }
}