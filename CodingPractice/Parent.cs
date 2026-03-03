using System;
using System.Text.RegularExpressions;
using static System.Console;

class Parent // 부모 클래스
{

    // private int _privateValue = 1;
    protected int _protectedValue = 2;
    public int _publicValue = 3;

    public int Value = 10;  // 부모 클래스의 int Value

    public void Show()  // 부모 클래스의 Method Show()
    {
        Console.WriteLine("Parent.Show()");
    }


    public void Greet()
    {
        WriteLine("안녕하세요!");
    }
}

class Child : Parent  // 자식 클래스
{
    public new int Value = 20;  // 부모 클래스의 Value를 숨김
    public void Study()
    {
        WriteLine("공부합니다.");
    }
    public void ShowValues()
    {
        // WriteLine(_privateValue);
        WriteLine(_protectedValue);
        WriteLine(_publicValue);
    }
    public new void Show()  // 부모 클래스의 Show() 메서드를 숨김
    {
        Console.WriteLine("Child.Show()");
    }
}