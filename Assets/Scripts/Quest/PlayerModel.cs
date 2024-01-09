using UnityEngine;

public class PlayerModel
{
    static PlayerModel instance = null;

    static public PlayerModel GetInstande()
    {
        if (instance == null)
        {
            instance = new PlayerModel();
        }
        return instance;
    }

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

    public void AttackTo(MonsterModel monsterModel)
    {
        Debug.Log("モンスターを攻撃");
        monsterModel.Damage(atk);
    }

    public void Damage(int damage)
    {
        Debug.Log("ダメージを受ける");
        // ダメージ処理の最大最小を設定
        hp = Mathf.Clamp(hp - damage, 0, maxHp);
    }

    public void UppAttackPoint()
    {
        atk += 2;
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
