// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным
// методом.
// N = 4532 -> 4

Console.Clear();

// int n = InputNumbers("Введите n: ");
// Recur(n);
// Console.WriteLine($"Количество цифр в числе N = {Recur(n)}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Recur(int n)
{
    return n < 10 ? 1 : 1 + Recur(n / 10);
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int count = m;
PrintSum(m, n, count = 0);

if (m > n)
{
    m = n;
    n = count;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);
}


