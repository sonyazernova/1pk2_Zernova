Console.WriteLine("введите предложение: ");
string input = Console.ReadLine();
string[] words = input.Split([' ', ',', '.', '!', '?', ':', ';'], StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("слова: ");
foreach (string word in words)
{
    Console.WriteLine(word);
}
string[] sentences = input.Split(['.', '!', '?'], StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("\nпредложения: ");
foreach (string sentence in sentences)
{
   Console.WriteLine(sentence.Trim());
}
