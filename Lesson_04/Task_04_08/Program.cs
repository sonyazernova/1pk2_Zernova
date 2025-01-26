int size = 10;

int[,] array1 = new int[size, size];
int[,] array2 = new int[size, size];
int[,] resultArray = new int[size, size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        array1[i, j] = rand.Next(1, 10);
        array2[i, j] = rand.Next(1, 10);
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        resultArray[i, j] = array1[i, j] * array2[i, j];
    }
}

Console.WriteLine("Первый массив:");
PrintMatrix(array1);

Console.WriteLine("\nВторой массив:");
PrintMatrix(array2);

Console.WriteLine("\nРезультирующий массив (произведение элементов):");
PrintMatrix(resultArray);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}