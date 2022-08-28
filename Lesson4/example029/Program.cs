
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Random rnd = new Random();
int[] numbers = new int[8];
string result = "";
for (int i = 0; i < 8; i++)
{
    numbers[i] = rnd.Next(100);
}
for (int i = 0; i < (numbers.Length); i++)
{
    result += (numbers[i] + " ");
}
Console.WriteLine($"Полученный массив - {result}");