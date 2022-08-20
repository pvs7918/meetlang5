/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);

    }
    return array;
}

int SumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum += array[i];
    }
    return sum;
}

int[] array = new int[12];
array = NewArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма отрицательных элементов: {SumNegative(array)}");
Console.WriteLine($"Сумма положительных элементов: {SumPositive(array)}");