// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int[,,] mas = new int[2, 2, 2];
Random rand = new Random();
void PrintArray(int[,,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                Console.Write($"{mas[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            mas[i, j, k] = rand.Next(10, 99);
        }


    }

}
PrintArray(mas);