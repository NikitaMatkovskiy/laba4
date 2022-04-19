using System;
class Program
{
    static void Main()
    {
        int m, n, a, b;
        Console.WriteLine("Введите количество строк");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начало отрезка a=");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начало отрезка b=");
        b = Convert.ToInt32(Console.ReadLine());

        int[,] matr = new int[m, n];
        int i, j;
        Random rand = new Random();
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
                matr[i, j] = rand.Next(a, b);
        }
        Console.WriteLine("Введеная матрица:");
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write("{0,6}", matr[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine("новая матрица");
        for (i = 0; i < m; i++)
        {
            for (j = n - 1; j >= 0; j--)

                if (matr[i, j] % 2 == 0)
                {
                    matr[i, j] = 0;
                    break;
                }
        }
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write("{0,6}", matr[i, j]);
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
