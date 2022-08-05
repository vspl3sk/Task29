// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = GetArray(8);
PrintArrayToConsole(array);

int[] GetArray(int arrayLenght)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,51);
    }
    return arr;
}

void PrintArrayToConsole(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length -1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}
