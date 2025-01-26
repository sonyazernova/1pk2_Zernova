Console.WriteLine("Введите размеры массива: ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[n, m];

Console.WriteLine("Исходная матрица: ");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = random.Next(-99, 100);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Преобразованная матрица: ");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (matrix[i, j] < 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(-matrix[i, j] + " ");
            Console.ResetColor();
        }
        else if (matrix[i, j] == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(1 + " ");
            Console.ResetColor();
        }
        else
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
    Console.WriteLine();
}
