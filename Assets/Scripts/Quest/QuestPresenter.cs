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
        playerModel = new PlayerModel();
        stageTableModel = new StageTableModel();

        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    void SetupMonster()
    {
        menuView.SetActive(false);
        // モンスターの生成
        MonsterModel monsterModel = stageTableModel.GetMonster(playerModel.CurrentStage);
        // モンスターの描画
        stageView.SpawnMonster();
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);

        if (stageTableModel.HasGameCleared(playerModel.CurrentStage))
        {
            Debug.Log("ゲームクリア");
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
        SceneManager.LoadScene("Quest");
    }
}
