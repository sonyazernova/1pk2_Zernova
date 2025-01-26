int[,] matrix =
{
    { 1, 0, 0 },
    { 0, 5, 0 },
    { 0, 0, 7 }
};

bool isDiagonal = true;
int n = matrix.GetLength(0);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i != j && matrix[i, j] != 0)
        {
            isDiagonal = false;
            break;
        }
    }
}

if (isDiagonal)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Матрица не является диагональной");
}