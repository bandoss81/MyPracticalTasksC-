//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



int SumNumber(int num)
{
    
  int counter = Convert.ToString(num).Length;
  int ten = 0;
  int result = 0;

  for (int i = 0; i < counter; i++)
  {
    ten = num - num % 10;
    result = result + (num - ten);
    num = num / 10;
  }
   return result;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);







