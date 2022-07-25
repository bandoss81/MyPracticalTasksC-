// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным
// методом.
// N = 4532 -> 4

Console.Clear();

int n = InputNumbers("Введите n: ");
Recur(n);
Console.WriteLine($"Количество цифр в числе N = {Recur(n)}");

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



