int[] array = new int[50];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 21);
}

int pairCount = 0;

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
            pairCount++;
    }
}

Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("Количество пар: " + pairCount);
