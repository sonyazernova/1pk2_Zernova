using System;
using System.IO;

public class FileOperations
{
    public static int CountLinesInFile(string filePath)
    {
        int lineCount = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine($"‘айл содержит {lineCount} строк.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("‘айл не найден.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"ќшибка при чтении файла: {ex.Message}");
        }

        return lineCount;
    }

    public static void TestCountLines()
    {
        Console.Write("¬ведите путь к файлу: ");
        string path = Console.ReadLine();
        CountLinesInFile(path);
    }
}