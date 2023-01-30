// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.Write("Введите размерность прямоугольной матрицы:");
int size = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(size); 
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Строка с наименьшей суммой элементов -> "+FindMinSumRow(array));


//--------metods-----------
int[,] GetArray(int value)
{
    int[,] array = new int[value, value];
    for (int i = 0; i < value; i++)
    {
        for (int j = 0; j < value; j++)
        {
            array[i, j] = new Random().Next(0, 50);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindMinSumRow(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i] += array[i, j];
        }
    }
    int sumRow = result[0];
    int minRow = 0;
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] < sumRow)
        {
            sumRow = result[i];
            minRow = i;
        }
    }
    return minRow;
}