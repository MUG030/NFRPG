using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTableModel
{
    // どのタイミングでモンスターを出すのかを管理する
    private int maxStageCount = 10;
    private List<bool> enemyPoint;

    public StageTableModel()
    {
        enemyPoint = new List<bool>();

        // 全部のステージに敵がいない状態で初期化
        for (int i = 0; i < maxStageCount; i++)
        {
            enemyPoint.Add(false);
        }

        enemyPoint[3] = true;
        enemyPoint[5] = true;
        enemyPoint[8] = true;
    }

    //　現在のステージに敵がいるかどうかを返す
    public bool IsEnemyPointAt(int cuurentStage)
    {
        return enemyPoint[cuurentStage];
    }

    // ステージがクリアしたかどうかを返す
    public bool HasGameCleared(int currentStage)
    {
        if (enemyPoint.Count <= currentStage)
        {
            return true;
        }
        return false;
    }
}
