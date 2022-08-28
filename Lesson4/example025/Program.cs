
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
if (A > 0 && B > 0)
{
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"{A}^{B} = {result}");
}
else
{
    Console.WriteLine("Введите натуральные числа");
}
