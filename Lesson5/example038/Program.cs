// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Random rnd = new Random();
int[] numbers = new int[10];
string strArray = "";
int min = 0;
int max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(-100, 100);
}
for (int i = 0; i < (numbers.Length); i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
for (int i = 0; i < (numbers.Length); i++)
{
    strArray += (numbers[i] + " ");
}
Console.WriteLine($"разница максимального и минимального элементов массива [{strArray}] = {max - min}");
