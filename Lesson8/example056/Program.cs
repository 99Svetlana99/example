// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] mas = new int[3, 4];
Random rand = new Random();
void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j] + " ");

        }
        Console.WriteLine();
    }
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rand.Next(10);


    }

}
int[] sum = new int[mas.GetLength(0)];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        sum[i] = sum[i] + mas[i, j];


    }

}
int max = sum[0];
int index = 1;


for (int i = 1; i < sum.GetLength(0); i++)
{
    if (sum[i] > max)
    {
        max = sum[i];
        index = i + 1;
    }
}

PrintArray(mas);
Console.WriteLine($"{index} строка");
