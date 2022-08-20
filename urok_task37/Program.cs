/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int[] PairsMultuplicationInArray(int[] array)
{
    int newlen;
    if (array.Length % 2 == 0)
        newlen = array.Length / 2;
    else
        newlen = array.Length / 2 + 1;

    int[] arr2 = new int[newlen];
    for (int i = 0; i < newlen; i++)
    {
        arr2[i] = array[i] * array[array.Length - i - 1];
    }
    return arr2;
}


Console.Write("Количество элементов в массиве :");
int N = Convert.ToInt32(Console.ReadLine()!);
int begin = 1;
int end = 5;
int[] array = new int[N];
array = NewArray(array, begin, end);

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Результат:");
Console.WriteLine("[" + string.Join(", ", PairsMultuplicationInArray(array)) + "]");
