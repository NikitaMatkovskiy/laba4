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
        int i, j, S;
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

        int index = 0, mins = int.MaxValue;
        for (i = 0; i < m; i++)
        {
            S = 0;
            for (j = 0; j < n; j++)
                S += matr[i, j];
            if (S < mins)
            {
                mins = S;
                index = i;
            }
        }
        Console.WriteLine("Строка с минимальной суммой элементов");
        for (j = 0; j < n; j++)
            Console.Write(matr[index, j] + "\t");
        int max = matr[index, 0];
        for (j = 0; j < n; j++)
        {
            if (matr[index, j] > max)
            {
                max = matr[index, j];
            }
        }
        Console.WriteLine("максимальный элемент в строке {0,6}", max);
        Console.ReadLine();
    }
}
