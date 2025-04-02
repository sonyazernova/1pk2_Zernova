using Microsoft.VisualBasic;

namespace Task_21_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите текст: ");
        string text = Console.ReadLine();
        Dictionary<string,int> wordCount = CountWord(text);
        Console.WriteLine("результат подсчета: ");
        foreach(var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

    }

    static Dictionary<string,int> CountWord(string text)
    {
        string[] words = text.ToLower().Split(new[] {' ',',','.','!','?',';',':'},StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string,int> wordCount = new();

        foreach(string word in words)
        {
            if(wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word]= 1;
            }
        }

        return wordCount;
    }

}
