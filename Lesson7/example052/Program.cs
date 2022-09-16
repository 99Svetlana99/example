// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int rowsCount = 3;
int columnsCount = 3;
double[] result = new Double[columnsCount];
Random rand = new Random();
int[,] matrix = GetMatrix(rowsCount, columnsCount);


int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(10);


        }
    }
    return matrix;
}
void PrintResult(double[] matrix)

{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + "; ");
    }
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

for (int j = 0; j < matrix.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    result[j] = Convert.ToDouble(sum) / Convert.ToDouble(matrix.GetLength(0));
}
PrintMatrix(matrix);
Console.WriteLine();
PrintResult(result);