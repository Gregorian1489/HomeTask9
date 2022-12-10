//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
int res = 0;
int Akkerman(int num, int num1)
{
  if (num == 0)
    return res = num1 + 1;
  else  
    if ((num != 0) && (num1 == 0))
      return res  = Akkerman(num - 1, 1);
    else
      return res = Akkerman(num - 1, Akkerman(num, num1 - 1));
}
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Akkerman(m,n);
Console.WriteLine();
Console.WriteLine($"Результат = {res}");

// Честно говоря, не понял как, но работает)))