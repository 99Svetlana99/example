// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет
int rowsCount = 4;
int columnsCount = 4;
Random rand = new Random();
int[,] matrix = GetMatrix(rowsCount, columnsCount);


int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 10);


        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");

        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите номер строки элемента (Счет начинаем с единицы)");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента (Счет начинаем с единицы)");
int columnsNumber = Convert.ToInt32(Console.ReadLine());
if (rowsNumber <= rowsCount && columnsNumber <= columnsCount)
{
    Console.WriteLine($"Искомый элемент в массиве: {matrix[rowsNumber - 1, columnsNumber - 1]}");
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Такого элемента в массиве не существует");
    PrintMatrix(matrix);
}