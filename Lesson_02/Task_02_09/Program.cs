Console.WriteLine("Введите начальную сумму вклада:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите процентную ставку:");
int p = int.Parse(Console.ReadLine());

Console.WriteLine("Введите желаемую сумму:");
int y = int.Parse(Console.ReadLine());
int years=0;
while(x<y){
    x+=(x*p)/100;
    years++;
}
Console.WriteLine($"количество лет: {years}");