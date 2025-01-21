int count=0;
while(true)
{
    Console.Clear();
    string input=Console.ReadLine();
    if(input=="exit"||input=="")
    {
        Console.WriteLine($"количество строк: {count}");
        break;
    }
    count++;
}


