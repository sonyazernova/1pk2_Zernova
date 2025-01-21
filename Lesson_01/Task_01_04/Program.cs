Console.WriteLine("Введите свой год рождения: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Введите свой месяц рождения: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Введите свой день рождения: ");
int day = int.Parse(Console.ReadLine());

DateTime today = DateTime.Today;
DateTime birthDate = new DateTime(year, month, day);
int age = today.Year - birthDate.Year;
if (birthDate > today.AddYears(-age)) age--;

if (age >= 18)
    Console.WriteLine("Пользователь совершеннолетний ");
else
    Console.WriteLine("Пользователь не совершеннолетний");
