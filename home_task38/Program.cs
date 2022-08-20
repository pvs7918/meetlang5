/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int DifBetweenMaxAndMinElemsInArray(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return max - min;
}


Console.Write("Укажите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int begin = 1;
int end = 100;
int[] array = new int[N];
array = NewArray(array, begin, end);

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.Write("Разница между максимальным и минимальным элементами массива: ");
Console.WriteLine(DifBetweenMaxAndMinElemsInArray(array));