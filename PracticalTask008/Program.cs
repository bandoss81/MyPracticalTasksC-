﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows,columns];

    for(int i = 0; i < rows; i++)
       for(int j = 0; j < columns; j++)
           array[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return array;        
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
Show2dArray(array);



