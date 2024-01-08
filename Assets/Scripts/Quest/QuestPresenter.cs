using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class QuestPresenter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI stageText;
    [SerializeField]
    PlayerStatusView playerStatusView;

    private int curretStage = 0;

    void Start()
    {
        stageText.text = string.Format("Stage {0}", curretStage);
        playerStatusView.UpdateText(10, 100, 5);
    }

    public void OnNextButton()
    {
        curretStage++;
        stageText.text = string.Format("Stage {0}", curretStage);
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene("Quest");
    }
}
