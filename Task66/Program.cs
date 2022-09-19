using System;
class workhome
{
    public static void Main()
    {
        task66();
    }
     public static void task66()
    {
        Console.Write("Введите m = ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите n = ");
        int n = Convert.ToInt16(Console.ReadLine());
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        Console.Write("Сумма натуральных чисел {0}", sum);
    }
}
