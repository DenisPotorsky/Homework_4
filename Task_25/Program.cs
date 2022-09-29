using static System.Console;
Console.Clear();
/*
Напишите цикл, 
1. который принимает на вход два числа (A и B) 
2. и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

WriteLine("Введите чило а: ");
int a = int.Parse(ReadLine());

if (a <= 0)
{
WriteLine("Введены некорректные данные");
    return;
}

WriteLine("Введите чило b: ");
int b = int.Parse(ReadLine());

if (b <= 0)
{
    WriteLine("Введены некорректные данные");
    return;
}

int res = Exponentiation(a, b);

WriteLine($"Число {a}, возведенное в степень {b} = {res}");

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
