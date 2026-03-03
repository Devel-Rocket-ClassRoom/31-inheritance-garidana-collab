using static System.Console;

class Parent // 부모 클래스
{

    // private int _privateValue = 1;
    protected int _protectedValue = 2;
    public int _publicValue = 3;


    public void Greet()
    {
        WriteLine("안녕하세요!");
    }
}

class Child : Parent  // 자식 클래스
{
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
}