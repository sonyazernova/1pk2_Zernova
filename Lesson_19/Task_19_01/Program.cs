Console.WriteLine("введите строку: ");
string input = Console.ReadLine();

Console.WriteLine("введите подстроку для поиска: ");
string search = Console.ReadLine();

if(input.Contains(search))
{
    Console.WriteLine("введите строку для замены: ");
    string replace = Console.ReadLine();
    Console.WriteLine($"результат: {input.Replace(search,replace)}");
}
else
{
    Console.WriteLine("подстрока не найдена в тексте");
}


