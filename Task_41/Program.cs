// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine("Введите количество чисел M для проверки");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

Console.WriteLine("А теперь сами числа");
for(int i = 0; i < arr.Length; i++)
arr[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваш набор чисел: {string.Join(", ", arr)}");

CountPlusNumber(arr);


void CountPlusNumber(int[] array)
{
    int count = 0;
    foreach(int elem in array)
    {
        if (elem > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} чисел больших 0");
}