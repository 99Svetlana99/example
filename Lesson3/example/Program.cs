
// Написать метод для разворота массива, не используя память под дополнительный массив

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
string result = "";
for (int i = 0; i < (array.Length / 2); i++)
{
    int buff = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = buff;
}
for (int i = 0; i < (array.Length); i++)
{
    result += (array[i] + " ");
}
Console.WriteLine($"Перевернутый массив - {result}");