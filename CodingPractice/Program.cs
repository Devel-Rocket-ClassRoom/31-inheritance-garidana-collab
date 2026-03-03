using System;
using System.Data;
using System.Globalization;
using System.Threading;
using static System.Console;

// README.md를 읽고 코드를 작성하세요.
// 1 기본 상속 법
Child child = new Child();
child.Greet();
child.Study();
WriteLine();

// 1 - 2
Dog dog = new();
dog.Name = "초코";
dog.Eat();
dog.Bark();



Cat cat = new();
cat.Name = "나비";
cat.Eat();
cat.Meow();

WriteLine();

// 2
Product product = new () {Name = "키보드", Price = 50000};
WriteLine(product.ToString());
WriteLine(product.GetType());

WriteLine();

// 3
Child child1 = new();
child1.ShowValues();
WriteLine(child1._publicValue);

WriteLine();

// 4
Manager manager = new ();
manager.ShowInfo();

WriteLine();

// 5-1
Student student = new ("홍길동", 3);
WriteLine($"이름: {student.Name}, 학년: {student.Grade}");

WriteLine();

// 5-2
// Dog 클래스가 Animal에게서 상속받는 생성자가 함께 출력됨
Dog dog1 = new();

WriteLine();


// 6-1
Dog dog2 = new Dog { Name = "멍멍이" };  // 이니셜라이저. 상속받는 Animal 클래스에 Name 필드가 존재
Animal animal = dog2;  // 암시적 변환 upcasting
dog2.Eat();
// 출력 될 때 전 생성자에 들어있던 문장이 함께 출력 됨

WriteLine();

// 6-2
Dog dog3 = (Dog)animal;  // 명시적 변환 다운캐스팅 downcasting
dog3.Bark();  // Animal parent 클래스의 animal 개체가 Dog 클래스로 변환되어 Dog 클래스에만 있는 
// Bark(); 가 호출될 수 있게됨

WriteLine();

// 6-3
// is 연산자로 타입 검사
Animal animal1 = new Dog() { Name = "뭉뭉이" };

if (animal1 is Dog)
{
    Dog dog4 = (Dog)animal1;
    dog4.Bark();
}
// 이 상황은 dog4.Bark();가 성공적으로 출력되었음으로 Animal animal1이 Dog클래스로 명시적 변환이
// 이루어졌다고 할 수 있음

WriteLine();

// 6-4
// 패턴 매칭은 is 연산자를 통한 타입 검사와 변환을 동시에 수행하는 것이다. (효율적)
// 새로운 Dog 클래스 개체를 Animal 클래스의 animal2로 변환
// 그리고 난 후 
Animal animal2 = new Dog() { Name = "멍뭉이" };  
if (animal2 is Dog doggo)
{
    doggo.Bark();
}
WriteLine();

// 6-5
Animal animal3 = new Cat() { Name = "야옹이" };

Dog doggy = animal3 as Dog;  // 캐스팅 실패 시 null
if (doggy != null)
{
    doggy.Bark();
}
else
{
    WriteLine("Dog 타입이 아닙니다.");
}

WriteLine();

// 7 
// 다형성 (Polymorphism)
Asset[] assets = new Asset[3];
assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
assets[1] = new House { Name = "아파트", Mortgages = 300 };
assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

foreach (Asset asset in assets)
{
    WriteLine(asset.Name);
}
// Asset 클래스의 개체 assets는 안에 Stock, House

WriteLine();

// 8-1 추상 클래스
Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
Circle circle = new Circle { Name = "원", Radius = 3 };

WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");

WriteLine();

// 8-2 추상 메서드
Car mclaren = new Car();
mclaren.Start();
mclaren.Stop();

WriteLine();

// 9 봉인 클래스
FinalClass obj = new FinalClass();
obj.Display();

WriteLine();

// 10 멤버 숨기기
Child kid = new Child();
Parent parent = kid;

Console.WriteLine($"child.Value: {kid.Value}");
Console.WriteLine($"parent.Value: {parent.Value}");
kid.Show();
parent.Show();

WriteLine();

// 11 is-a 관계
Dog doberman = new Dog();
WriteLine(doberman is Animal);
WriteLine(doberman is Dog);
WriteLine(doberman is Cat);
WriteLine();

// 12
