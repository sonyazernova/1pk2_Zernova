using System.Runtime.CompilerServices;

namespace Task_10_09;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Bob",1);
        dog.Bark();
        dog.Eat();
        dog.Eat();
        
        Cat cat = new Cat("sonya",2);
        cat.Meow();
        cat.Play();
        cat.Play();

        
    }

}
