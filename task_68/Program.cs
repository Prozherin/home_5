// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

class Program
{
    static int Ackermann(int m, int n)
    {
        // Базовый случай
        if (m == 0)
        {
            return n + 1;
        }
        // Рекурсивный случай, когда m > 0
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine("Результат функции Аккермана: " + result);
    }
}
