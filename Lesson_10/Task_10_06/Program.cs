namespace Task_10_06;

class Program
{
    static void Main(string[] args)
    {
       ArrayGeneration(10);
    }
    public static void ArrayGeneration(int n)
    {
        int[,] array = new int[n,n];
        Random r = new Random();
        for(int i = 0;i<n;i++)
        {
            for(int j = 0;j<n;j++)
            {
                array[i,j]=r.Next(100);
                Console.Write(array[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
}
