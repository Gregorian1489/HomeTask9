// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum = 0;
void RecurSum (int num, int num1)
{
    if (num > num1) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (num++);
    RecurSum(num,num1);

}

Console.WriteLine("Введите число M:");
int nums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int nums1 = Convert.ToInt32(Console.ReadLine());

RecurSum(nums,nums1);
