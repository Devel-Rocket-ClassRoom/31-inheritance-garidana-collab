using static System.Console;

class Animal
{
    public string Name;

    public void Eat()
    {
        WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        WriteLine($"{Name}이(가) 멍멍 ! !");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        WriteLine($"{Name}이(가) 야옹 ! !");
    }
}