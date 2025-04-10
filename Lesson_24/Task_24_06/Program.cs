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
            Console.WriteLine($"���� �������� {lineCount} �����.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("���� �� ������.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"������ ��� ������ �����: {ex.Message}");
        }

        return lineCount;
    }

    public static void TestCountLines()
    {
        Console.Write("������� ���� � �����: ");
        string path = Console.ReadLine();
        CountLinesInFile(path);
    }
}