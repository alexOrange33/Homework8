﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

System.Console.Write("Введите количество строк:");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows,columns); 
PrintArray(array);
System.Console.WriteLine();
SortRows(ref array);
PrintArray(array);




//---------metods---------
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

void SortRows(ref int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxIndexElement = j;
            for(int k = j+1;k<array.GetLength(1);k++)
            {
                if(array[i,k]>array[i,maxIndexElement]) maxIndexElement = k;
            }
            int temp = array[i,j];
            array[i,j] = array[i,maxIndexElement];
            array[i,maxIndexElement] = temp;
            
        }
    }
}