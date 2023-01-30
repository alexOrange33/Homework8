// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



System.Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите значение с которого начнется заполнение: ");
int start = int.Parse(Console.ReadLine()!);

int[,] array = FillArraySpiral(n,m);
PrintArray(array);


//--------metods---------------
void PrintArray(int[,] array)
{
  
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10) System.Console.Write($"0{array[i,j]} ");
            else System.Console.Write(array[i,j]+" ");              
        }
        System.Console.WriteLine();
    }
}

int[,] FillArraySpiral(int n, int m)
{
    int[,] array = new int[n, m];
    int difPosX = 1;
    int difPosY = 0;
    int rows = 0;
    int colums = 0;
    int changes = 0;
    int enter = m;
    for (int i = 0; i < array.Length; i++)
    {
        array[rows, colums] = start + i;
        if (--enter == 0)
        {
            enter = m * (changes % 2) + n * ((changes + 1) % 2) - (changes / 2 - 1) - 2;
            int temp = difPosX;
            difPosX = -difPosY;
            difPosY = temp;
            changes++;
        }
        colums += difPosX;
        rows += difPosY;
    }
    return array;
}