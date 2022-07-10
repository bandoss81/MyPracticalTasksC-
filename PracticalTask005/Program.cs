//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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

// Console.Write("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandomArray(numbers, 100, 1000);
// ShowArray(numbers);

// int evenNum = EvenNumbers(numbers);
// Console.WriteLine($"{evenNum} (Количество чётных чисел в массиве)");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int EvenSum(int[] array)
{
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 1)
        {
            sumElements = sumElements + array[i];
        }
    }
    return sumElements;
}

// Console.Write("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// RandomArray(numbers, -100, 100);
// ShowArray(numbers);
// int evenSum = EvenSum(numbers);
// Console.WriteLine($"{evenSum} (Сумма чисел в массиве на нечетных позициях)");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Difference(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    if (max < array[i])
    {
        max = array[i];
    }
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    if (min > array[i])
    {
        min = array[i];
    }
    int dif = max - min;
    Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами: {dif}");
}

Console.Write("Введите количество чисел в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
RandomArray(array, 1, 100);
ShowArray(array);
Difference(array);

