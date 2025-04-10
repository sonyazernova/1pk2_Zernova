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

            Console.WriteLine($"Найдено {matchingLines.Count} строк, содержащих слово '{searchWord}' (без учета регистра):");
            foreach (string match in matchingLines)
            {
                Console.WriteLine(match);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }

        return matchingLines;
    }

    public static void TestFindLines()
    {
        Console.Write("Введите путь к файлу: ");
        string path = Console.ReadLine();
        Console.Write("Введите слово для поиска: ");
        string word = Console.ReadLine();
        FindLinesWithWord(path, word);
    }
}