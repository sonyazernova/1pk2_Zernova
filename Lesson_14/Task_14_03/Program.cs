namespace Task_14_03;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine($"Факториал 5: {Factorial(5)}");
            Console.WriteLine($"Факториал 10: {Factorial(10)}");
            Console.WriteLine($"Факториал 15: {Factorial(-15)}");
        }
        catch (ArgumentException ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Число N должно быть не отрицательным!");
        }

        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
    
}
