// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



Random rnd = new Random();
int[] numbers = new int[8];
int result = 0;
string strArray = "";

for (int i = 0; i < 8; i++)
{
    numbers[i] = rnd.Next(100, 999);
}
for (int i = 0; i < (numbers.Length); i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
for (int i = 0; i < (numbers.Length); i++)
{
    strArray += (numbers[i] + " ");
}

Console.WriteLine($"Количество четных чисел в массиве [{strArray}] - {result}");
