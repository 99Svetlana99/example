// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");
int number1 = number % 10;
int number2 = (number - number1) / 10;
int number3 = number2 % 10;
Console.WriteLine($"Результат выполнения равен {number3}");
