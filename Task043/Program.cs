// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Function(int B1, int K1, int B2, int K2)
{
    int X = (B2 - B1) / (K1 - K2);
    return X;
}
Console.Write("Введите координату B1: ");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату K1: ");
int K1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату B2: ");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату K2: ");
int K2 = Convert.ToInt32(Console.ReadLine());

int X = Function(B1, K1, B2, K2);
int Y = K1 * X + B1;
Console.Write($"Точка пересечения двух прямых: ({X},{Y})"); 

