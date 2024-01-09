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

    public void AttackTo(PlayerModel playerModel)
    {
        Debug.Log("Playerを攻撃");
        playerModel.Damage(atk);
    }

    public void Damage(int damage)
    {
        Debug.Log("ダメージを受ける");
        // ダメージ処理の最大最小を設定
        hp = Mathf.Clamp(hp - damage, 0, maxHp);
    }

    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        return false;
    }
}
