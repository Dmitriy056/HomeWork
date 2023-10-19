// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = SumNaturalNumbers(m, n);
        static int SumNaturalNumbers(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }
        else
        {
            return start + SumNaturalNumbers(start + 1, end);
        }
    }
    Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, sum);
    