// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// 1 Вариант:

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Итоговый результат = " + Math.Pow(num1, num2));

// 2 Вариант:
Console.WriteLine("Введите первое число, которое мы возводим в степень");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - степень в которую мы возводим число");
int num2 = Convert.ToInt32(Console.ReadLine());

double GetPowNum(int num, int pow)
{
    int p;

    if (pow < 0)
    {
        p = -pow;
    }
    else
    {
        p = pow;
    }
    
    int i;              // вводим счетчик
    double result;         // результат расчета
    result = 1;

    for (i = 1; i <= p; i++)
    {
        result *= num;
    }
    if (pow < 0)
    {
        return 1 / result;
    }
    else
    {
        return result;
    }
}
Console.WriteLine("Итоговый результат = " + GetPowNum(num1, num2));