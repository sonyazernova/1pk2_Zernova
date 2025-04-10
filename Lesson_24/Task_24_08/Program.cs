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
                Console.WriteLine($"����� '{searchText}' ������� ������� �� '{replaceText}' � �����.");
            }
            else
            {
                File.Delete(tempFilePath);
                Console.WriteLine($"����� '{searchText}' �� ������ � �����.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("���� �� ������.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"������ ��� ��������� �����: {ex.Message}");
        }
    }

    public static void TestFindAndReplace()
    {
        Console.Write("������� ���� � �����: ");
        string path = Console.ReadLine();
        Console.Write("������� ����� ��� ������: ");
        string searchText = Console.ReadLine();
        Console.Write("������� ����� ��� ������: ");
        string replaceText = Console.ReadLine();
        FindAndReplaceInFile(path, searchText, replaceText);
    }
}