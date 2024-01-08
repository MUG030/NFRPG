using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI stageText;
    [SerializeField]
    PlayerStatusView playerStatusView;

    private PlayerModel playerModel;
    private StageTableModel stageTableModel;

    void Start()
    {
        playerModel = new PlayerModel();
        stageTableModel = new StageTableModel();

        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);

        if (stageTableModel.HasGameCleared(playerModel.CurrentStage))
        {
            Debug.Log("ゲームクリア");
        }else if (stageTableModel.IsEnemyPointAt(playerModel.CurrentStage))
        {
            Debug.Log("敵が出現した");
        }
    }

    public void OnBackButton()
    {
        playerModel.BackTown();
        SceneManager.LoadScene("Quest");
    }
}
