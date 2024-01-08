using UnityEngine;

public class MonsterModel
{
    private int maxHp;
    private int hp;
    private int atk;

    public int MaxHp
    {
        get {return maxHp;}
    }
    public int HP
    {
        get {return hp;}
    }
    public int Atk
    {
        get {return atk;}
    }

    public MonsterModel()
    {
        maxHp = 10;
        hp = maxHp;
        atk = 6;
    }
}
