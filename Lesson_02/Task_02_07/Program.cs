const double g=9.8;
Console.WriteLine("Таблица скорости свободного падения:");
Console.WriteLine("Время (c)\tСкорость (м/с)");
for(double t=0;t<=10;t+=0.5){
    double v=g*t;
    Console.WriteLine($"{t:F1}\t\t{v:F2}");
}