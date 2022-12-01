/* За cдача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

Console.WriteLine("Введите целое неотрицательное число");
uint n = Convert.ToUInt32(Console.ReadLine());

WriteFromNumberToUnit(n);

void WriteFromNumberToUnit(uint num)
{
    if (num < 1) return;
    else if (num == 1) Console.Write($"{num}");
    else
    {
        Console.Write($"{num},  ");
        WriteFromNumberToUnit(num - 1);
    }

}

