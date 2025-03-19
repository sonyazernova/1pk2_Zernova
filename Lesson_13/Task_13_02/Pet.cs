class Pet
{
    #region Свойства
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public double Weight {  get; set; }
    public bool IsHealthy { get; set; }
    #endregion

    #region Конструкторы
    public Pet(string name, string species, int age, double weight, bool isHealthy)
    {
        Name = name;
        Species = species;
        Age = age;
        Weight = weight;
        IsHealthy = isHealthy;
    }
    public Pet(string name, string species) 
    {
        Name = name;
        Species = species;
        Age=0;
        Weight = 0.0;
        IsHealthy = true;
    }
    #endregion

    #region Методы
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Вид: {Species}, Возраст: {Age}, Вес: {Weight}, Здоров: {(IsHealthy ? "Здоров" : "Не здоров")}");
    }
    public void ChangeWeight(double newWeight)
    {
        Weight = newWeight;
        Console.WriteLine($"Вес изменен на {Weight}");
    }
    public void ChangeIsHealthy(bool isHealthy)
    {
        IsHealthy = isHealthy;
        Console.WriteLine($"Состояние питомца изменено: {IsHealthy}");
    }
    #endregion
}