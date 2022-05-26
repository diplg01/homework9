// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

int m = 13;
int n = 20;
Console.WriteLine($"Все натуральные числа кратные 3-ем в промежутке от {m} до {n}: ");
Recursion(m, n);

void Recursion(int firstNumber, int lastNumber)
{
    if(firstNumber == lastNumber) return;
    if (firstNumber % 3 == 0) Console.Write(firstNumber + " ");
    Recursion(firstNumber + 1, lastNumber);
}