using System;
class Program
{
    static void Main()
    {
        double P = 1;
        int n, i, Sa, index = 0, pol = 0;
        float sr, ko = 0;
        Console.WriteLine("Введите количество элементов");
        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Введите элементы массива");
        for (i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
            if (i % 2 == 0)
                P = P * array[i];
        }
        Console.WriteLine("произведение элементов с четными индексами: {0}", P);
        for (i = 0; i < n; i++)
        {
            if (array[i] > 0)
                pol += array[i];
            if (array[i] > 0)
                ko = ko + 1;
        }
        sr = pol / ko;

        Console.WriteLine("ср. арифметическое положительных элементов=: {0}", sr);
        for (i = 0; i < n; i++)
        {
            if (array[i] > -10 && array[i] < 10)

                Console.WriteLine("номер первого однозначного числа: {0}: ", i);
            if (array[i] > -10 && array[i] < 10)
                break;

        }
        Console.WriteLine("индексы тех элементов, значения которых по модулю больше 20:");
        for (i = 0; i < n; i++)
        {
            if (array[i] > 20 || array[i] < -20)
                Console.Write("{0} ", i);
        }


        Console.ReadLine();
    }
}
