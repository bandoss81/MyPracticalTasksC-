// Задача 10

void CutNumberVoid()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Текущее случайное число: " + num);

    int sot = num / 100;
    int ed = num % 10;

    int result = (num - sot * 100 - ed) / 10;
    Console.WriteLine("Вторая цифра этого числа: " + result);
}

CutNumberVoid();
