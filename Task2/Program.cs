Console.Clear();
Console.Write("Введите 1-ое число: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-ие число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (i > n)
 if (i > m)
 Console.Write("Максимальное число: " + i);
 else
 Console.Write("Максимальное число: " + m);
else if (n > m)
 Console.Write("Максимальное число: " + n);
else
 Console.Write("Максимальное число: " + m);

