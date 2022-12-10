// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Numbers (int num)
{
    if (num == 0)
    {
        return;
    }
    Console.Write($"{num} ");
    Numbers(num - 1);
}

Console.WriteLine("Введите число:");
int nums = Convert.ToInt32(Console.ReadLine());
Numbers(nums);
