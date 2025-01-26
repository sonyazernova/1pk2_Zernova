int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    int num;
    do
    {
        num = rand.Next(-50, 51);
    } while (Array.Exists(array, x => Math.Abs(x) == Math.Abs(num)));
    array[i] = num;
}

int maxMod = array[0];
foreach (var num in array)
{
    if (Math.Abs(num) > Math.Abs(maxMod))
        maxMod = num;
}

Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("Наибольшее по модулю число: " + maxMod);

