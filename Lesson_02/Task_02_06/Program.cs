Console.WriteLine("таблица значений функции y=|x|");
Console.WriteLine("  y        x");
for(double x=-4;x<=4;x+=0.5){
    double y=Math.Abs(x);
    Console.WriteLine($"{y:F1}\t{x:F1}");
    
}
    

