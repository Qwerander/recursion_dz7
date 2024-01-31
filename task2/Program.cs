class Program
{
    static void Main()
    {
        int m, n;

        Console.Write("Введите значение m: ");
        m = EnterNumber();
        Console.Write("Введите значение n: ");
        n = EnterNumber();



        if (m < 0 || n < 0)
        {
            Console.WriteLine("Значения m и n должны быть неотрицательными ");
            return;
        }
        else
        {
            int result = AckermannFunction(m, n);
            Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");
        }
    }
    static int EnterNumber()
    {

        int number = Convert.ToInt32(Console.ReadLine());


        return number;

    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }

}
