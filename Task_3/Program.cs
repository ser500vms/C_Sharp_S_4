// Task_3:
// Напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Summ(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum *= i; 
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
Console.Write($"{num} -> {Summ(num)}");

// Решение на семинаре:
