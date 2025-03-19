class Car
{
    #region Свойства
    public string LicensePlate {  get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public int CurrentSpeed { get; private set; }

    private const int MaxSpeed = 90;
    #endregion

    #region Конструкторы
    public Car(string licensePlate, string brand, string color)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Color = color;
        CurrentSpeed = 0;
    }
    
    public Car(string licensePlate, string brand) 
    { 
        LicensePlate = licensePlate;
        Brand = brand;
        Color = "Черный";
        CurrentSpeed = 0;
    }
    #endregion

    #region Методы
    public void Drive(int acceleration)
    {
        while (true)
        {
            CurrentSpeed += acceleration;
            Console.WriteLine($"Текущая скорость: {CurrentSpeed}");
            if (CurrentSpeed > MaxSpeed)
            {
                Brake();
                break;
            }
            Thread.Sleep(100);
        }
    }

    public void Brake()
    {
        CurrentSpeed = 0;
        Console.WriteLine("Автомобиль остановлен");
    }
    #endregion



}