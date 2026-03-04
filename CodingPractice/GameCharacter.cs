using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    

    // 게임 캐릭터 생성자
    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public abstract void Attack();
    public void ShowStatus()
    {
        WriteLine($"[{Name}] 체력: {Health}");
    }
    
}

class Warrior : GameCharacter
{
    public int Strength;
    public Warrior(int strength)
    {
        Strength = strength;
    }
    public void Attack()
    {

    }
}

class Mage : GameCharacter
{

}