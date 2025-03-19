class Dog
{
    public string Name {get;set;}
    public int  Age {get;set;}
    public bool IsHungry {get;private set;}
    public Dog(string name,int age)
    {
        Name = name;
        Age = age;
        IsHungry = true;
    }
    public void Bark()
    {
        Console.WriteLine($"собака {Name} гавкает");     
    }
    public void Eat()
    {
        if(IsHungry)
        {
            Console.WriteLine($"собака {Name} кушает ");
            IsHungry = false;
        }
        else 
        {
            Console.WriteLine($"собака {Name} сытая ");
        }
    }
}