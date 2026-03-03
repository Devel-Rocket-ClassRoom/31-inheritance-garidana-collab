using System;
using System.Runtime.Intrinsics.Arm;

class Employee
{
    protected string _department = "개발팀";

    public void ShowDepartment()
    {
        Console.WriteLine($"소속 부서: {_department}");
    }
}

class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"부서: {base._department}");
        base.ShowDepartment();  // parent class의 메서드 호출

    }
}