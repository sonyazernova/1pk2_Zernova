Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
Random rand = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(10, 100);
    }
}

Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);

int minElement = int.MaxValue;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (matrix[i, j] < minElement)
        {
            minElement = matrix[i, j];
        }
    }
}

Console.WriteLine($"\nМинимальный элемент матрицы: {minElement}");

int[,] multipliedMatrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        multipliedMatrix[i, j] = matrix[i, j] * minElement;
    }
}

Console.WriteLine("\nМатрица после умножения на минимальный элемент:");
PrintMatrix(multipliedMatrix);

int[] flatArray = new int[n * n];
int index = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        flatArray[index++] = multipliedMatrix[i, j];
    }
}

Array.Sort(flatArray);
Array.Reverse(flatArray);

int[] topFive = flatArray[..5];

Console.WriteLine("\nМатрица с выделенными максимальными элементами:");
PrintMatrixWithHighlights(multipliedMatrix, topFive);

static void PrintMatrix(int[,] matrix)
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

static void PrintMatrixWithHighlights(int[,] matrix, int[] highlights)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (Array.Exists(highlights, element => element == matrix[i, j]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(matrix[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
