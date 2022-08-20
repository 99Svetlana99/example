// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = number;
if (number >= 10000 & number <= 99999)
{
    int digit = number % 10;
    number = number / 10;
    int number1 = digit * 10000;
    digit = number % 10;
    number = number / 10;
    number1 += digit * 1000;
    digit = number % 10;
    number = number / 10;
    number1 += digit * 100;
    digit = number % 10;
    number = number / 10;
    number1 += digit * 10;
    digit = number % 10;
    number = number / 10;
    number1 += digit;

    if (startNumber == number1)
    {
        Console.WriteLine($"{number1} является палиндромом ");
    }
    else
    {
        Console.WriteLine($"{number1}  не является палиндромом ");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}



