/* 
Дано натуральное число N и последовательность из N элементов.
Требуется сдвинуть массив на указанное количество элементов.
Входные данные:
записано натуральное число N (N ≤ 103). 
*/

int[] NewArray(int[] array, int begin, int end)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(begin, end + 1);

    }
    return array;
}

int[] ShiftArray(int[] array, int shift)
{
    // сдвигаем элементы массива на указанное количество позиций
    int[] array2 = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        int ni = i + shift;
        if (ni > array.Length - 1)
            ni = ni - array.Length;
        if (ni < 0)
            ni = ni + array.Length;
        array2[ni] = array[i];
    }
    return array2;
}

Console.Write("Укажите количество элементов в массиве (<=103): ");
int N = Convert.ToInt32(Console.ReadLine());
int begin = 1;
int end = 100;
int[] array = new int[N];
array = NewArray(array, begin, end);
Console.Write("На какое количество элементов сдвинуть массив: ");
int srcShift = Convert.ToInt32(Console.ReadLine());
int shift = srcShift;
/*if (shift > array.Length)
{
    shift %= array.Length;
}*/

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Массив после сдвига на {srcShift} элемента: ");
Console.WriteLine("[" + string.Join(", ", ShiftArray(array, shift)) + "]");