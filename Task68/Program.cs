using System;
class workhome
{
    public static void Main()
    {
        task68();
    }

public static void task68()
    {
        Console.Write("Введите n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Результат вычисления {0}",Ak(n,m));
    }

    public static int Ak(int n, int m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        else
        {
            if ((n != 0) && (m == 0))
            {
                return Ak(n - 1, 1);
            }
            else
            {
                return Ak(n - 1, Ak(n, m - 1));
            }
        }
    }
}