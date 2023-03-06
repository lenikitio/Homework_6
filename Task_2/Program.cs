// Напишите программу, которая задаёт массив из n элементов, 
// которые необходимо заполнить случайными значениями и определить существует ли 
// пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.

// [1,2,3,3] -> [1,2,3,4]

Console.Clear();

int[] GetArray(int n, int min, int max)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for(int i = 0; i < n; i++)
    result[i] = rnd.Next(min, max + 1);
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

void CheckCopy(int[] array, int min, int max)
{
    int size = array.Length;
    Random rnd = new Random();
    for(int i = 0; i < size - 1; i++)
    {
        while(array[i] == array[i + 1])
        array[i] = rnd.Next(min, max + 1);
    }
    Console.WriteLine($"Убрали совпадение: [{string.Join(", ", array)}]");
}


Console.Write("Введите количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значения элементов в массиве: ");
int mn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элементов в массиве: ");
int mx = Convert.ToInt32(Console.ReadLine());

int[] OurArray = GetArray(count, mn, mx);
CheckCopy(OurArray, mn, mx);
