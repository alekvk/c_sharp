/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите неотрицательное  целое число m ");
ulong n1 = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число n");
ulong n2 = Convert.ToUInt64(Console.ReadLine());

Console.Write($"Значение функции Аккермана A(m, n) для m = {n1} и n = {n2} равно  ");
Console.WriteLine(FuncAckerm(n1, n2));

// Вычисление функции Аккермана
ulong FuncAckerm(ulong m, ulong n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FuncAckerm(m - 1, 1);
    else return FuncAckerm(m - 1, FuncAckerm(m, n - 1));
}

