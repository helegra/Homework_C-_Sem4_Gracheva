// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int num = new Random().Next();

Console.WriteLine("Пусть некое число = " + num);

int GetCountNum(int num)
{
    int result;
    int Sum = 0;

    while (num > 0)
    {
        result = num % 10;
        Sum += result;
        num /= 10;
    }
    return Sum;
}
Console.WriteLine("Тогда сумма цифр этого числа = " + GetCountNum(num));
