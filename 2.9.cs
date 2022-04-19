using System;
class Program
{
    static void Main()
    {
        int n, i, a, b;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начало отрезка a=");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите начало отрезка b=");
        b = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Random rand = new Random();
        Console.WriteLine("Заполненный массив:");
        for (i = 0; i < n; i++)
        {
            array[i] = rand.Next(a, b);
            Console.Write("{0,6}", array[i]);
        }
        Console.WriteLine();
        int pmin = array[0], p, poz = 0;
        int pos = 0;
        for (i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                p = array[i];
                if (pmin > p || pmin < 0)
                {
                    pmin = array[i];

                    poz = i;
                }
            }

        }
        if (poz <= 0)
        {
            Console.WriteLine("положительных элементов нет");
        }
        if (poz > 0)
        {
            for (i = 0; i < n; i++)
            {
                if (poz == i)
                {
                    array[i] = 0;
                }
            }
            Console.WriteLine("массив после обнуления минимального положительного элемента");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,6}", array[i]);
            }
        }
        Console.ReadLine();
    }
}
