using static System.Console;

class Animal
{
    public string Name;

    public Animal()  // animal 기본 생성자
    {
        WriteLine("Animal 기본 생성자");
    }

    public void Eat()
    {
        WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public Dog()  // dog 기본 생성자 // base 생략시  부모 클래스의 생성자가 자동으로 호출됨
    {
        WriteLine("Dog 생성자");  
    }
    public void Bark()
    {
        WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}