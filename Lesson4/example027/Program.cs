// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int result = 0;
for (int i = 0; i < number.ToString().Length; i++)
{
    result += number1 % 10;
    number1 = number1 / 10;
}
Console.WriteLine($"{number} -> {result}");