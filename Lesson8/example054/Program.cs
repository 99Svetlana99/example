// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] mas = new int[8, 8];
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
PrintArray(mas);
Console.WriteLine();
int tmp;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int k = 0; k < mas.GetLength(1); k++)
    {
        for (int j = 0; j < mas.GetLength(1) - 1; j++)
        {
            if (mas[i, j] > mas[i, j + 1])
            {
                tmp = mas[i, j];
                mas[i, j] = mas[i, j + 1];
                mas[i, j + 1] = tmp;
            }
        }
    }
}
PrintArray(mas);