// Task_2:
// Напишите программу, которая на вход принимает число и выдает кол-во цифр в числе.
// 456 -> 2
// 4 -> 1
// 83 -> 2

// Мое решение через массив и преобразование:
// int CountNum(int num)
// {
//     num = Math.Abs(num);
//     char[] arr = num.ToString().ToCharArray(); // переводим число в массив символов.
//     int lenght = arr.Length; // считаем колл-во символов
//     return lenght;
// }

// int GetInput(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int numbers = GetInput("Введите число: ");
// Console.Write($"{numbers} -> {CountNum(numbers)}");

// Мое решение математическим методом через цикл:

// int CountNum(int num)
// {
//     num = Math.Abs(num);
//     int count = 0;
//     for (int i = 1; num > 0; i++)
//     {
//         num = num / 10;
//         count = i;
//     }
//     return count;
// }

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = GetInput("Введите число: ");
Console.Write($"{numbers} -> {CountNum(numbers)}");

// Решение на семинаре

int CountNum(int num)
{
    num = Math.Abs(num);
    int count = 0;
    while (num > 0)
    {
        count++;
        num/=10;
    }
    return count;
}