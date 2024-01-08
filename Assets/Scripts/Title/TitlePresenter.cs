using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePresenter : MonoBehaviour
{
    public void OnNewGameButton()
    {
        SceneManager.LoadScene("Town");
    }
    public void OnContinueButton()
    {
        SceneManager.LoadScene("Town");
    }
}
