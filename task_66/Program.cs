/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

Console.WriteLine("Введите натуральное число начала диапазона");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число конца диапазона");
uint n = Convert.ToUInt32(Console.ReadLine());

// Переворачиваем границы диапазона при ошибочном вводе чисел
if (m > n)
{
    uint temporary = m;
    m = n;
    n = temporary;
}

Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} равна ");
Console.WriteLine(SumFromNum1ToNum2(m, n));

// Рекурсивная функция вычисления суммы натуральных элементов в промежутке от M до N
uint SumFromNum1ToNum2(uint min, uint max)
{
    if (min > max) return 0;
    else return max + SumFromNum1ToNum2(min, max - 1);
}
