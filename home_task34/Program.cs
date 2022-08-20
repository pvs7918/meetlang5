/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int CalcCntEvenNumbersInArray(int[] array)
{
    int cnt = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            cnt++;
    }
    return cnt;
}


Console.Write("Укажите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int begin = 100;
int end = 999;
int[] array = new int[N];
array = NewArray(array, begin, end);

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Количество четных чисел в массиве: {CalcCntEvenNumbersInArray(array)}");