// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int M = 5;
int[] array = new int[M];
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        result++;
    }
}

Console.WriteLine($"количество чисел больше 0 = {result}");