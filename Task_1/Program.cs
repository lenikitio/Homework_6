// Напишите программу, которая задаёт массив из n элементов,
// которые необходимо заполнить случайными значениями 
// и сдвинуть элементы массива влево, или вправо на 1 позицию.

// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

int[] arr = GetArray(8, -1, 20);
int[] LeftArray = ShiftLeft(arr);
int[] Right = ShiftRight(arr);


int[] GetArray(int n, int min, int max)
{
    Random rnd = new Random();
    int[] result = new int[n];
    for(int i = 0; i < n; i++)
    result[i] = rnd.Next(min, max + 1);
    Console.WriteLine($"Ваш массив: [{string.Join(", ", result)}]");
    return result;
}

int[] ShiftLeft(int[] array)
{
    int size = array.Length;
    int[] LArray = new int[size];
    LArray[size - 1] = array[0];
    for(int i = 0; i < size - 1; i++)
    LArray[i] = array[i + 1];
    Console.WriteLine($"Ваш массив со сдвигом влево: [{string.Join(", ", LArray)}]");
    return array;
}


int[] ShiftRight(int[] array)
{
    int size = array.Length;
    int[] RArray = new int[size];
    RArray[0] = array[size - 1];
    for(int i = 1; i < size; i++)
    RArray[i] = array[i - 1];
    Console.WriteLine($"Ваш массив со сдвигом влево: [{string.Join(", ", RArray)}]");
    return array;
}
