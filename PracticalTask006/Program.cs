// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
