using System;
class Program
{
    static void Main()
    {
        int n, i, S = 0, ot = 0, index = 0;
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
            if (array[i] % 2 != 0)
                S += array[i];
        }
        for (i = 0; i < n; i++)
        {
            if (array[i] < 0)
                ot += array[i];
            if (array[i] < 0)
                ko = ko + 1;
        }
        sr = ot / ko;
        Console.WriteLine("Сумма нечетных элементов массива: {0}", S);
        Console.WriteLine("ср. арифметическое отрицательных чисел=: {0}", sr);
        Console.WriteLine("Индексы элементов > 15:");
        for (i = 0; i < n; i++)
        {
            if (array[i] > 15)
                Console.Write("{0} ", i);
        }
        for (i = 0; i < n; i++)
        {
            if (array[i] % 3 == 0 && array[i] < 0)

                Console.WriteLine("номер первого отрицательного элемента делящегося на 3: {0}: ", i);
            if (array[i] % 3 == 0 && array[i] < 0)
                break;

        }

        Console.ReadLine();
    }
}
