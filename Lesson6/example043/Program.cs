// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[,] coef = { { "b1", "" }, { "k1", "" }, { "b2", "" }, { "k2", "" } };


for (int i = 0; i < coef.GetLength(0); i++)
{
    for (int j = 0; j < coef.GetLength(1); j += 2)
    {
        Console.WriteLine($"Введите коэффициент {coef[i, j]}");
        coef[i, j + 1] = Convert.ToString(Console.ReadLine());
    }
}


double x = (Convert.ToDouble(coef[2, 1]) - Convert.ToDouble(coef[0, 1])) / (Convert.ToDouble(coef[1, 1]) - Convert.ToDouble(coef[3, 1]));
double y = (Convert.ToDouble(coef[1, 1]) * x) + Convert.ToDouble(coef[0, 1]);


Console.WriteLine($"({x}; {y})");


