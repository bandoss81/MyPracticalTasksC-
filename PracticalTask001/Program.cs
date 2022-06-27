// Задача 2

/*
int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first number: ");
num2 = Convert.ToInt32(Console.ReadLine());


if(num1 < num2)
{
    Console.WriteLine("Max = " + num2);
}
else
{
    Console.WriteLine("Max = " + num1);
}
*/

// Задача 4

/*int num1, num2, num3, max;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;
if(num1 < num2)
{
    max = num2;
    if(num2 < num3)
    {
        max = num3;
    }
}

Console.WriteLine("Максималиное число: " + max);
*/

// Задача 6

/*int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Число ЧЕТНОЕ");
}
else
{
    Console.WriteLine("Число НЕЧЕТНОЕ");
}
*/

// Задача 8

int num, res = 1;

Console.Write("Введите число от 1 и более: ");
num = Convert.ToInt32(Console.ReadLine());

if(res == 1)
{
    res += 1;
}
while(res <= num)
{
    Console.Write(res + "  ");
    res += 2;
}

