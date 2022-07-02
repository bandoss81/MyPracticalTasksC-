// Задача 19

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









