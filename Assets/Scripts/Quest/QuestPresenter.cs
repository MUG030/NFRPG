using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI stageText;
    [SerializeField]
    PlayerStatusView playerStatusView;
    [SerializeField]
    StageView stageView;
    [SerializeField]
    GameObject menuView;

    private PlayerModel playerModel;
    private StageTableModel stageTableModel;

    void Start()
    {
        playerModel = PlayerModel.GetInstande();    // new PlayerModel();
        stageTableModel = new StageTableModel();

        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    void SetupMonster()
    {
        menuView.SetActive(false);
        // モンスターの生成
        MonsterModel monsterModel = stageTableModel.GetMonster(playerModel.CurrentStage);
        // モンスターの描画&Viewを取得
        MonsterView monsterView = stageView.SpawnMonster();
        monsterView.UpdateHPText(monsterModel);
        monsterView.AddListenerOnTap(() => OnTapMonster(monsterView, monsterModel));
        
    }

    void OnTapMonster(MonsterView monsterView, MonsterModel monsterModel)
    {
        Debug.Log("Presenterの処理");
        AttackToMonster(monsterView, monsterModel);
        AttackToPlayer(monsterModel);
    }

    void AttackToMonster(MonsterView monsterView,MonsterModel monsterModel)
    {
        if (monsterModel.IsDead())
        {
            return;
        }
        
        //  Playerからモンスターへの攻撃
        playerModel.AttackTo(monsterModel);
        if (monsterModel.IsDead())
        {
            // モンスター削除
            Destroy(monsterView.gameObject);
            // ボタン再表示
            menuView.SetActive(true);

            // prayerの攻撃力を上げる
            playerModel.UppAttackPoint();
            playerStatusView.UpdateText(playerModel);
            return;
        }
        monsterView.UpdateHPText(monsterModel);
    }

    void AttackToPlayer(MonsterModel monsterModel)
    {
        //  モンスターからPlayerへの攻撃
        monsterModel.AttackTo(playerModel);
        playerStatusView.UpdateText(playerModel);
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);

        if (stageTableModel.HasGameCleared(playerModel.CurrentStage))
        {
            Debug.Log("ゲームクリア");
            playerModel.BackTown();
            SceneManager.LoadScene("Town");
        }
        else if (stageTableModel.IsEnemyPointAt(playerModel.CurrentStage))
        {
            Debug.Log("敵が出現した");
            SetupMonster();
        }
    }

    public void OnBackButton()
    {
        playerModel.BackTown();
        SceneManager.LoadScene("Town");
    }
}
