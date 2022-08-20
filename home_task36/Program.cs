/* 
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int CalcSummOfOddElemsInArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum += array[i];
    }
    return sum;
}


Console.Write("Укажите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int begin = 1;
int end = 10;
int[] array = new int[N];
array = NewArray(array, begin, end);

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {CalcSummOfOddElemsInArray(array)}");