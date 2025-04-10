using System;
using System.IO;
using System.Text;

public class TextReplacer
{
    public static void FindAndReplaceInFile(string filePath, string searchText, string replaceText)
    {
        try
        {
            string tempFilePath = Path.GetTempFileName();
            bool found = false;

            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(searchText))
                    {
                        found = true;
                        line = line.Replace(searchText, replaceText);
                    }
                    writer.WriteLine(line);
                }
            }

            if (found)
            {
                File.Delete(filePath);
                File.Move(tempFilePath, filePath);
                Console.WriteLine($"Текст '{searchText}' успешно заменен на '{replaceText}' в файле.");
            }
            else
            {
                File.Delete(tempFilePath);
                Console.WriteLine($"Текст '{searchText}' не найден в файле.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не найден.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
        }
    }

    public static void TestFindAndReplace()
    {
        Console.Write("Введите путь к файлу: ");
        string path = Console.ReadLine();
        Console.Write("Введите текст для поиска: ");
        string searchText = Console.ReadLine();
        Console.Write("Введите текст для замены: ");
        string replaceText = Console.ReadLine();
        FindAndReplaceInFile(path, searchText, replaceText);
    }
}