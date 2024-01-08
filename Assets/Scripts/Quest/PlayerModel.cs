using UnityEngine;

public class PlayerModel
{
    private int maxHp;
    private int hp;
    private int atk;
    private int currentStage;

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
    public int CurrentStage
    {
        get {return currentStage;}
    }

    public PlayerModel()
    {
        maxHp = 100;
        hp = maxHp;
        atk = 6;
        currentStage = 0;
    }

    public void NextStage()
    {
        currentStage++;
    }
    public void BackTown()
    {
        currentStage = 0;
    }
}
