class Program
{
    static void Main()
    {
        Console.Clear();
        Random random = new();

        int length = random.Next(10, 20);

        int[] array = new int[length];

        Console.WriteLine($"Сгенерирован массив длиной {length} со случайными элементами:");

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100);
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine("\nВывод элементов массива в обратном порядке:");
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{array[index]} ");
            PrintArrayReversed(array, index - 1);
        }
    }
}
