// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
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
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(m, n, min, max);
// Show2dArray(array);
// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// Show2dArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int temp = SumLineElements(array, i);
//     if (sumLine > temp)
//     {
//         sumLine = temp;
//         minSumLine = i;
//     }
// }

// Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int n = 4;
int[,] spiralArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
    spiralArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

Show2dArray(spiralArray);

