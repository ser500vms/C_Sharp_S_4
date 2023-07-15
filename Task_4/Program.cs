// Task_4:
// Напишите программу, которая выводит массив и 8 элементов, заполненный нулями и единицами в случайном порядке.

void PrintArray(int[] array)
{
    int lenght = array.Length; // Сколько элементов в массиве?
    for (int i = 0; i < lenght-1; i++) // пробежка по всем элементам и вывод
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[lenght - 1]);
    Console.WriteLine();
}

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    for (int i = 0; i < lenght; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Задайте длину: ");
int[] array = new int[size];
FillArray(array);
PrintArray(array);

Console.WriteLine($"[{String.Join(",", array)}]");