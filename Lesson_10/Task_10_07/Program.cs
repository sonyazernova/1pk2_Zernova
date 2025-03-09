namespace Task_10_07;

class Program
{
    static void Main(string[] args)
    {
        char[,] array = GenerateCharArray(5,10);
        PrintCharArray(array);
    }
    static char[,] GenerateCharArray(int rows,int cols)
    {
        char[,] array = new char[rows,cols];
        Random random = new Random();
        string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        for(int i = 0;i<rows;i++)
        {
            for(int j = 0;j<cols;j++)
            {
                array[i,j] = russianAlphabet[random.Next(russianAlphabet.Length)];
            }
        }
        return array;
    }
    static void PrintCharArray(char[,] array)
    {
        for(int i = 0;i<array.GetLength(0);i++)
        {
            for(int j = 0;j<array.GetLength(1);j++)
            {
                Console.Write(array[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
}
