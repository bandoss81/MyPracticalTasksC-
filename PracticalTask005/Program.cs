﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void RandomArray(int[] array, int min, int max)
{
    for (int i = 0; i<array.Length; i++ )
    {
       array[i] = new Random().Next(min, max);
    }
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}", array[i]);
        if (i < (array.Length - 1))
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.Write(" -> ");
}

int EvenNumbers(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            evenNum++;
        }
    }
  return evenNum;
}

Console.Write("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers, 100, 1000);
ShowArray(numbers);

int evenNum = EvenNumbers(numbers);
Console.WriteLine($"{evenNum} (Количество чётных чисел в массиве)");