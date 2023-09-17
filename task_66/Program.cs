// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (m > n)
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N");
            return;
        }

        int sum = 0;

        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сумма натуральных чисел от {0} до {1}: {2}", m, n, sum);
    }
}