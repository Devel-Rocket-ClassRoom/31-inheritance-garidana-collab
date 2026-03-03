using System;
using System.Collections.Generic;
using System.Text;

abstract class Vehicle
{
    abstract public void Start();  // 구현 없이 선언만
  
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
}

class Car : Vehicle
{
    public override void Start()  // 추상 메서드를 상속받아 구현할땐 public overrid 쓸것
    {
        Console.WriteLine("자동차 시동을 켭니다");
    }
   
}