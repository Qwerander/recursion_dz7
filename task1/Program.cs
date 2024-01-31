void PrintNumbersInRange(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        PrintNumbersInRange(m + 1, n);
    }
}

void EnterNumbers()
{
    Console.Write("Введите M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    PrintNumbersInRange(M, N);
}

EnterNumbers();