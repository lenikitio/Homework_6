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
//GetDecision(k1, k2, b1, b2);

bool CheckLine (int koff1, int koff2, int const1, int const2)
{
    if(koff1 == koff2)
    {
        if(const1 == const2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }

    }
    else
    GetDecision(koff1, koff2, const1, const2);
    return true;
}


void GetDecision(int koff1, int koff2, int const1, int const2)
{
    double x = (const2 - const1)/(koff1 - koff2);
    double y = koff1 * x + const1;
    Console.WriteLine($"Ваши отрезки пересекаются в точке: ({x};{y})");
}