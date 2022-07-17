// Задача 47: Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] arrayDouble = new double[m, n];

void CreateArrayRandom(double[,] arrayDouble)
{

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayDouble[i, j] = new Random().NextDouble()*20-10;
        }
    }
}

void ShowArrayDouble(double[,] arrayDouble)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double num = Math.Round(arrayDouble[i, j], 1);
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

CreateArrayRandom(arrayDouble);

//ShowArrayDouble(array);


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] TransformationArrayInt(double[,] arrayDouble)
{
    int[,] arrayInt = new int[arrayDouble.GetLength(0), arrayDouble.GetLength(1)];
    for (int i = 0; i < arrayDouble.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++)
        {
            arrayInt[i, j] = Convert.ToInt32(arrayDouble[i, j]);
        }
    }
    return arrayInt;
}

int[,] arrayInt = new int[m, n];

arrayInt = TransformationArrayInt(arrayDouble);

void ShowArrayInt(int[,] arrayInt)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(arrayInt[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//ShowArrayInt(arrayInt);

// Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if (position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0)
// {
//     int result = arrayInt[position[0] - 1, position[1] - 1];
//     Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
    int countNumbers = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            countNumbers++;
    }

    int[] numbers = new int[countNumbers];

    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }

    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

ShowArrayInt(arrayInt);

Console.Write($"Cреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
        arithmeticMean += arrayInt[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"столбца {i + 1}: {arithmeticMean}");
}
