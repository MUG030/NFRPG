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

    void Start()
    {
        playerModel = new PlayerModel();

        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);
        playerStatusView.UpdateText(playerModel);
    }

    public void OnNextButton()
    {
        playerModel.NextStage();
        stageText.text = string.Format("Stage {0}", playerModel.CurrentStage);
    }

    public void OnBackButton()
    {
        playerModel.BackTown();
        SceneManager.LoadScene("Quest");
    }
}
