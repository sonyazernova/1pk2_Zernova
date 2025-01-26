int[] array = new int[10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}

Console.WriteLine("Исходный массив: " + string.Join(", ", array));

ReverseArray(array, 0, array.Length / 2 - 1);

ReverseArray(array, array.Length / 2, array.Length - 1);

Console.WriteLine("Результат: " + string.Join(", ", array));

void ReverseArray(int[] array, int start, int end)
{
    while (start < end)
    {
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        start++;
        end--;
    }
}