/* Решение в группах задач:
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);

    }
    return array;
}

int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}


int[] array = new int[4];
array = NewArray(array);
Console.WriteLine("Элементы до:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Элементы после:");
Console.WriteLine("[" + string.Join(", ", InvertArray(array)) + "]");