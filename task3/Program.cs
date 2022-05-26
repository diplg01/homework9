// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(n,m) = 29

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вычисление функции Аккермана: {Accerman(num1, num2)}");

int Accerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n != 0 && m == 0) return Accerman(n - 1, 1);
    else if (n > 0 && m > 0) return Accerman (n-1, Accerman(n, m - 1));
    else return 0;
}