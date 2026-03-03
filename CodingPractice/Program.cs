using System;
using System.Data;
using System.Globalization;
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

