using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePresenter : MonoBehaviour
{
    public void OnNewGameButton()
    {
        PlayerModel.GetInstande().DeleteSaveData();
        SceneManager.LoadScene("Town");
    }
    public void OnContinueButton()
    {
        PlayerModel.GetInstande().Load();
        SceneManager.LoadScene("Town");
    }
}
