// Задача 2


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
