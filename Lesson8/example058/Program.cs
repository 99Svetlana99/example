// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49


int[,] mas1 = new int[3, 4];
int[,] mas2 = new int[mas1.GetLength(0), mas1.GetLength(1)];
int[,] mul = new int[mas1.GetLength(0), mas1.GetLength(1)];
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
void FillArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = rand.Next(10);


        }

    }
}
FillArray(mas1);
FillArray(mas2);
for (int i = 0; i < mul.GetLength(0); i++)
{
    for (int j = 0; j < mul.GetLength(1); j++)
    {
        mul[i, j] = mas1[i, j] * mas2[i, j];


    }

}
PrintArray(mas1);
Console.WriteLine();
PrintArray(mas2);
Console.WriteLine();
PrintArray(mul);