using static System.Console;
Console.Clear();
/*
Напишите программу, 
1. которая задаёт массив из 8 элементов 
2. и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
WriteLine("Введите длину массива: ");
int arLangth = int.Parse(ReadLine());
WriteLine("Диапазон от: ");
int range1 = int.Parse(ReadLine());
WriteLine("Диапазон до: ");
int range2 = int.Parse(ReadLine());

RandomDigit(arLangth, range1, range2);
void RandomDigit(int arl, int r1, int r2)
{
    int[] array = new int[arl];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(r1, r2);
        if (i == 0)
        {
            Write($"[{array[i]}, ");
        }
        else if (i == array.Length - 1)
        {
            Write($"{array[array.Length - 1]}]");
        }
        else
        {
            Write($"{array[i]}, ");
        }
    }
}