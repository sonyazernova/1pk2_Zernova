class Cat
{
    public string Name {get;set;}
    public int  Age {get;set;}
    public bool IsTired {get;private set;}
    public Cat(string name,int age)
    {
        Name = name;
        Age = age;
        IsTired = false;
    }
    public void Meow()
    {
        Console.WriteLine($"кошка {Name} мяукает");
    }
    public void Play()
    {
        if(!IsTired)
        {
            Console.WriteLine($"кошка {Name} играет");
            IsTired = true;
        }
        else 
        {
            Console.WriteLine("кошка устала");
        }
        
        
    

    }
    
}