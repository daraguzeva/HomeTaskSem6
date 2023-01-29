// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
string arr = Console.ReadLine();
string[] num = arr.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] n = num.Select(Int32.Parse).ToArray();
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
