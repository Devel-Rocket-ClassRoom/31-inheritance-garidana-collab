using System;
using System.Collections.Generic;
using System.Text;

// 추상 클래스는 상속을 통해서만 사용가능 (상속 필수)

abstract class Shape  // 추상 클래스
{
    public string Name;

    // 추상 메서드
    public abstract double GetArea();  // 구현 없이 선언만 함
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    // 추상 메서드를 상속받는 클래스에서 꼭 구현해야함
    public override double GetArea()  
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
