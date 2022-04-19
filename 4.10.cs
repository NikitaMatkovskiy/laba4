using System;
class Program
{
    static void Main()
    {
        int m, n;
        Console.WriteLine("Введите количество строк");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] matr = new int[m, n];
        int i, j;
        for (i = 0; i < m; i++)
        {
            Console.WriteLine("Введите элементы {0}-й строки", i + 1);
            for (j = 0; j < n; j++)
                matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Введеная матрица:");
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
                Console.Write("{0,6}", matr[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine("Строки с отрицательными элементами");
        for (i = 0; i < m; i++)
        {
            int k = 0;
            for (j = 0; j < n; j++)
            {
                if (matr[i, j] < 0)
                {
                    k = k + 1;
                }
            }
            if (k == n)
                Console.WriteLine("{0,6}", i + 1);
        }
        Console.ReadLine();
    }
}
