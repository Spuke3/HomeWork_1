Console.Clear();

int i = 1;
bool not = true;

Console.Write("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + m);
    while (i <= m)
    {
        if (i % 2 != 1)
            {
            Console.Write(i + ", ");
            not = false;
            }
            i++;
    }

        if (not)
        {
            Console.WriteLine("Нет чётных чисел!");
        }
