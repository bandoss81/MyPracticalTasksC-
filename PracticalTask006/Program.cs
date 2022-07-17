// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massNumbers = new int[m];

void InputNumber(int m)
{
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Comparison(int[] massNumbers)
{
    int num = 0;
    for(int i = 0; i < massNumbers.Length; i++)
    {
        if(massNumbers[i] > 0) num += 1;
    }
    return num;
}

InputNumber(m);
Console.WriteLine($"Введено чисел больше 0: {Comparison(massNumbers)}");
*/

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] value = new double[2, 2];
double[] crossPoint = new double[2];

void InputValue()
{
    for (int i = 0; i < value.GetLength(0); i++)
    {
        Console.Write($"Введите значения {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < value.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите значение k: ");
            else Console.Write($"Введите значение b: ");
            value[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] value)
{
  crossPoint[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
  crossPoint[1] = crossPoint[0] * value[0,0] + value[0,1];
  return crossPoint;
}

void OutputResponse(double[,] value)
{
  if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Decision(value);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputValue();
OutputResponse(value);