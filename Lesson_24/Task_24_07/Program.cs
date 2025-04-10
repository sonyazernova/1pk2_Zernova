using System;
using System.Collections.Generic;
using System.IO;

public class FileSearch
{
    public static List<string> FindLinesWithWord(string filePath, string searchWord)
    {
        List<string> matchingLines = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }

            Console.WriteLine($"������� {matchingLines.Count} �����, ���������� ����� '{searchWord}' (��� ����� ��������):");
            foreach (string match in matchingLines)
            {
                Console.WriteLine(match);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("���� �� ������.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"������ ��� ������ �����: {ex.Message}");
        }

        return matchingLines;
    }

    public static void TestFindLines()
    {
        Console.Write("������� ���� � �����: ");
        string path = Console.ReadLine();
        Console.Write("������� ����� ��� ������: ");
        string word = Console.ReadLine();
        FindLinesWithWord(path, word);
    }
}