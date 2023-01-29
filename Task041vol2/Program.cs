// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
string arr = Console.ReadLine();
// Console.Write(arr);
string[] num = arr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] n = num.Select(Int32.Parse).ToArray();
//Console.WriteLine();
// for (int i = 0; i < n.Length; i++)
// {
//     Console.Write($"{n[i]} ");
// }
int count = 0;
for (int j = 0; j < n.Length; j++)
{
    if (n[j] > 0)
    {
        count++;
    }
}
//Console.WriteLine();
Console.Write($"Колличество положительных элементов в массиве: {count}.");
