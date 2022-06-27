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

int num1, num2, num3, max;

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
