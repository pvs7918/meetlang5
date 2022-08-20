/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int FindNumbersInArrayInRange(int[] array, int min, int max)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min & array[i] <= max)
            cnt += 1;
    }
    return cnt;
}


Console.Write("Количесто элементов в массиве :");
int N = Convert.ToInt32(Console.ReadLine()!);
int begin = 1;
int end = 200;
int[] array = new int[N];
array = NewArray(array, begin, end);

Console.WriteLine("Элементы массива:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99]");
Console.WriteLine($" равно ->:{FindNumbersInArrayInRange(array, 10, 100)}");