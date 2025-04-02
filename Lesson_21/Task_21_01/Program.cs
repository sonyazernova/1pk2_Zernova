List<int> numbers = new List<int>();
Random random = new Random();

for(int i = 0;i<10;i++)
{
    numbers.Add(random.Next(1,101));
}

Console.WriteLine("исходный список: ");
ShowList(numbers);

List<int> result = numbers.Where(n=>n%2==0).Select(n=>n*10).ToList();

Console.WriteLine("новый список: ");
ShowList(result);

void ShowList(List<int> list)
{
    foreach(int item in list)
    {
        Console.WriteLine(item);
    }
}
