namespace Task_13_02;

class Program
{
    static void Main(string[] args)
    {
        Pet pet = new Pet("Барсик", "Кот", 3, 4.5, true);

        pet.DisplayInfo();
        pet.ChangeWeight(5.0);
        pet.ChangeIsHealthy(false);
        pet.DisplayInfo();
    }
}
