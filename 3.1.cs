using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double P = 1;
        int n, i;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();

        var arr = array.OrderBy(x => Sort(x));
        Console.WriteLine(string.Join("\t", arr.ToArray()));

        Console.ReadKey();
    }

    static int Sort(int x)
    {
        if (x == 0) return 0;
        else return 1;

    }
}
