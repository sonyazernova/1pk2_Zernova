int[] array = new int[20];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 21);
}

Console.WriteLine("Массив: " + string.Join(", ", array));

int[] uniqueElements = new int[array.Length];
int uniqueCount = 0;

for (int i = 0; i < array.Length; i++)
{
    bool isUnique = true;

    for (int j = 0; j < array.Length; j++)
    {
        if (i != j && array[i] == array[j])
        {
            isUnique = false;
            break;
        }
    }

    if (isUnique)
    {
        uniqueElements[uniqueCount] = array[i];
        uniqueCount++;
    }
}

int[] result = new int[uniqueCount];
for (int i = 0; i < uniqueCount; i++)
{
    result[i] = uniqueElements[i];
}

Console.WriteLine("Уникальные элементы: " + string.Join(", ", result));
