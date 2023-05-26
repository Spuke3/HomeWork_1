Console.Clear();
Console.Write("Введите первое число: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

 if (i > n)
{
        Console.WriteLine("Первое число " + i + " больше чем второе " + n);
}
    else
{
        Console.WriteLine("Второе число " + n + " больше чем первое " + i);
}
            
