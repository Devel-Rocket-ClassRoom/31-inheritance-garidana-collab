using System;
using System.Collections.Generic;
using System.Text;

sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("이 클래스는 상속할 수 없습니다.");
    }
}

// class FirstClass : FinalClass  상속할 수 없다고 뜸

