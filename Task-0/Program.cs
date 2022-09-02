/*----------------------------------------------------------------------------------------------------------------------
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных элементов массива.
----------------------------------------------------------------------------------------------------------------------*/

int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] newArr=new int[size];

    for(int i=0; i<size; i++)
        newArr[i]= new Random().Next(minVal,maxVal+1);

    return newArr;
}

void ShowArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
}

int FindNegSum(int[] arr)
{
    int sum=0;
    for(int i=0; i<arr.Length; i++)
        if(arr[i]<0)
            sum+=arr[i];
    return sum;
}

int[] arr;