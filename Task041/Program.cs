// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Задайте размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
 Console.Write("Заданный массив: ");
for (int j = 0; j < array.Length; j++)
{
     Console.Write($"{array[j]} ");
}
for (int k = 0; k < array.Length; k++)
{
    if (array[k] > 0)
    {
        count++;
    }
}
Console.WriteLine();
 Console.Write($"Колличество положительных элементов в массиве: {count}.");