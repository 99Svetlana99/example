// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.Write(number1);
// }
// else
// {
//     Console.Write(number2);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2 & number1 > number3)
// {
//     Console.Write(number1);
// }
// if (number2 > number1 & number2 > number3)
// {
//     Console.Write(number2);
// }
// if (number3 > number1 & number3 > number2)
// {
//     Console.Write(number3);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.Write("четное");
// }
// else
// {
//     Console.Write("нечетное");
// }




// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= number)
{
    Console.WriteLine(i);
    i += 2;
}



















