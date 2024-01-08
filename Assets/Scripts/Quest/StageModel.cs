using UnityEngine;

public class StageModel
{
    MonsterModel monsterModel = null;

    public MonsterModel Monster
    {
        get { return monsterModel; }    // モンスターを取得する
        set { monsterModel = value; }   // モンスターをセット・設定する
    }

    // モンスターがいるかどうかを返す
    public bool HasMonster()
    {
        if (monsterModel == null)
        {
            return false;
        }
        return true;
    }
}
