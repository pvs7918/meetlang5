/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует 
ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);

    }
    return array;
}

bool FindNumberInArray(int[] array, int numb)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numb)
            return true;
    }
    return false;
}


Console.Write("Количесто элементов в массиве :");
//int N = int.Parse(Console.ReadLine()!);
int N = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[N];
Console.Write("Какой элемент искать? :");
//int numb = int.Parse(Console.ReadLine()!);
int numb = Convert.ToInt32(Console.ReadLine()!);


array = NewArray(array);
Console.WriteLine("Элементы массива:");
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Наличие элемента {numb} в массиве ->:{FindNumberInArray(array, numb)}");