using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownPresenter : MonoBehaviour
{
    public void OnQuestButton()
    {
        SceneManager.LoadScene("Quest");
    }
    public void OnSaveButton()
    {
        PlayerModel.GetInstande().Save();
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
