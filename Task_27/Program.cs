using static System.Console;
Console.Clear();

/*
Напишите программу, 
1. которая принимает на вход число 
2. и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
WriteLine("Введите число:");
int number = int.Parse(ReadLine());

int result = SumDigit(number);

WriteLine($"Сумма цифр числа {number} = {result}");

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}
