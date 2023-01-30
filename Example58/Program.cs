// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.Write("Введите количество строк первой матрицы:");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество столбцов первой матрицы (!!!оно же количество строк второй матрицы!!!):");
int columns = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество  столбцов второй матрицы:");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(rows,columns);
PrintArray(array1);
System.Console.WriteLine();
int[,] array2 = GetArray(columns,columns2);
PrintArray(array2);
System.Console.WriteLine();

int[,] resulted = MultiplicationMatrix(array1,array2);
PrintArray(resulted);



//--------metods----------
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {

            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i,j] += array1[i,k]*array2[k,j];
            }

        }
    }
    return result;
}