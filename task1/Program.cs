// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void EvenNumbers(int m, int n)
{
    if (m > n) return;

    if (m % 2 == 0)
    {
    System.Console.WriteLine(m);
        EvenNumbers(m + 2, n);
    }
    else
    {
        EvenNumbers(m + 1, n);
        return;
    }
}

int m = InputInt("Введите число М");
int n = InputInt("Введите число N");
System.Console.WriteLine($"Четные натуральные числа в промежутке от {m} до {n}:");
EvenNumbers(m, n);