// Task_1:
// Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10 1+2+3+4
// 8 -> 36
// Мое решение:

// int Summ(int number)
// {
//     int summ = 0;
//     int i = 0;
//     while (i < number)
//     {
//         summ = summ + number;
//         number--;
//     }
//     return summ;
// }

// int GetInput(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int num = GetInput("Введите число: ");
// Console.Write($"{num} -> {Summ(num)}");
// Решение на семинаре:
int Summ(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; // Операция += означает, что к sum прибавится значение i-го элемента 
    }
    return sum;
}