namespace Task_10_08;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1,2,3,4,5};
        Console.WriteLine($"индекс элемента 3: {Find(array,3)}");
    }
    static int Find(int[] array, int target)
    {
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]==target)
            {
                return i;
            }
        }
        return -1;
    }
}
