Console.WriteLine("введите начальную температуру: ");
double startTemp=double.Parse(Console.ReadLine());
Console.WriteLine("введите конечную температуру: ");
double endTemp=double.Parse(Console.ReadLine());
Console.WriteLine("введите шаг: ");
double step=double.Parse(Console.ReadLine());

for(double i=startTemp;i<=endTemp;i+=step){
    Console.WriteLine($"температура в цельсиях: {i}; температура в фаренгейтах: {i*1.8+32}");
}

