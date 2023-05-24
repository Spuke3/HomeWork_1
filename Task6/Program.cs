Console.Clear();

Console.Write("Введите число:");
int i = Convert.ToInt32(Console.ReadLine());

    if (i % 2 == 1)
        {
        Console.WriteLine("Число " + i + " является: Нечетным");
        }
    else
        {
        Console.WriteLine("Число " + i + " является: Четным");
        }
