// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваши уравнения y={k1}x+{b1} и y={k2}x+{b2}");

CheckLine(k1, k2, b1, b2);


void CheckLine (int koff1, int koff2, int const1, int const2)
{
    if(koff1 == koff2)
    {
        if(const1 == const2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
        }

    }
    else
    GetDecision(koff1, koff2, const1, const2);
}


void GetDecision(int koff1, int koff2, int const1, int const2)
{
    double Const = const2 - const1;
    double koff = koff1 - koff2;
    double x = Math.Round(Const, 2) / Math.Round(koff, 2);
    double y = koff1 * x + const1;
    Console.WriteLine($"Ваши отрезки пересекаются в точке: ({x};{y})");
}