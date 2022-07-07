//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*
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
*/



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.Write("Какое количество рандомных цифр вывести на экран: ");
int m = Convert.ToInt32(Console.ReadLine());


void Main()
{
  
  int[] array = new int[m];
  Random myRandom = new Random();
 
  
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = myRandom.Next(0, 20);
    Console.Write("{0}", array[i]);
    if (i < (array.Length - 1))
    {
      Console.Write(", ");
    }
  }
  
}

Console.Write("[");
Main();
Console.Write("]");



