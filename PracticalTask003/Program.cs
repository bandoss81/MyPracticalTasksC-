// Задача 19
/*
Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

void PalindromeNumber(string num)
{
  if (num[0] == num[4] && num[1] == num[3])
  {
    Console.WriteLine("Ваше число: - палиндром.");
  }
  else Console.WriteLine("Ваше число: - НЕ палиндром.");
}

if (num.Length == 5)
{
  PalindromeNumber(num);
}
else Console.WriteLine("Введи правильное число");
*/

// Задача 23

Console.Write("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int number)
{
    int cube;
    int count = 1;
    while(count <= number)
    {
        cube = count * count * count;
        
        Console.WriteLine(cube);
        count++;
    }
}

Console.WriteLine("Таблица кубов чисел от 1 до N: ");
Cube(number);





