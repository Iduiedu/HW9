using System;
class workhome
{
    public static void Main()
    {
        task64();
    }

    public static void task64()
    {
        Console.Write("Введите m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int i = m; i <= n; i++)
        {
            Console.Write($"{i} \t");
        }
    }
}