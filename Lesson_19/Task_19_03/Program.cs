namespace Task_19_03;

class Program
{
    static void Main(string[] args)
    {
       List<string> lines = new();
       int counter = 1;
       while(true)
       {
        Console.Write($"введите строку {counter}:");
        string line = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(line))
        {
            break;
        }
        lines.Add(line);
        counter++;
       }
       Console.WriteLine($"результат: {string.Join("-",lines)}");
    
       
       
        
       
    }
}
