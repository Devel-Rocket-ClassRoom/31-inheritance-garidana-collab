using System;
using System.Collections.Generic;
using System.Text;

abstract class GameCharacter
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }

    public abstract void Attack();
    public abstract void ShowStatus();
}

class Warrior : GameCharacter
{
    
}

class Mage : GameCharacter
{

}