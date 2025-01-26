char[,] matrix1 =
{
    { 'f', 'h', 'h'},
    { 'w', 'g', 'k'},
    { 'a', 'f', 'g'}
};

char[,] matrix2 =
{
    { 'f', 'c','h'},
    { 'm', 'g', 'z'},
    { 'a', 'o', 'd'}
};

bool areEqual = true;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (matrix1[i, j] != matrix2[i, j])
        {
            areEqual = false;
            break;
        }
    }
}

if (areEqual)
{
    Console.WriteLine("Матрицы равны");
}
else
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (matrix1[i, j] == matrix2[i, j])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix1[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix1[i, j] + " ");
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (matrix1[i, j] == matrix2[i, j])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix2[i, j] + " ");
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix2[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}




