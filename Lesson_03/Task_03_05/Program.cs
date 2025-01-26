int[] rainfalls = new int[30];

Random random = new Random();

for (int i = 0; i < rainfalls.Length; i++)
{
    rainfalls[i] = random.Next(0, 301);
    Console.Write(rainfalls[i] + " ");
}

Console.WriteLine("\n");

for (int i = 0;i < rainfalls.Length; i+=10)
{
    int maxRainfallCount = 0;
    int maxRainfallDay = 0;
    int totalRainfalls = 0;
    Console.WriteLine("Дни без осадков: ");
    for (int j = i; j < i + 10; j++)
    {
        if (rainfalls[j] == 0)
        {
            Console.Write($"{j+1} ");
        }

        if (rainfalls[j] > maxRainfallCount)
        {
            maxRainfallCount = rainfalls[j];
            maxRainfallDay = j + 1;
        }

        totalRainfalls += rainfalls[j];
    }
    Console.WriteLine();
    Console.WriteLine($"Общее количество осадков в декаде {i / 10 + 1}: {totalRainfalls}");
    Console.WriteLine($"День с самыми сильными осадками: {maxRainfallDay}, количество осадков: {maxRainfallCount}");
    Console.WriteLine();
}
