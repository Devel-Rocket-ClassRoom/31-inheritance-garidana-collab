using System;
using System.Collections.Generic;
using System.Text;

class Asset
{
    public string Name;

}

class Stock : Asset
{
    public int Shares;
}

class House : Asset
{
    public int Mortgages;
}