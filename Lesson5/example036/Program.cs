// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Random rnd = new Random();
int[] numbers = new int[10];
int result = 0;
string strArray = "";
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(-100, 100);
}
for (int i = 0; i < (numbers.Length); i++)
{
    if (i % 2 != 0)
    {
        result += numbers[i];
    }
}
for (int i = 0; i < (numbers.Length); i++)
{
    strArray += (numbers[i] + " ");
}
Console.WriteLine($"суммa элементов массива [{strArray}], стоящих на нечётных позициях. = {result}");
