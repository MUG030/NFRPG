using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestPresenter : MonoBehaviour
{
    public void OnBackButton()
    {
        SceneManager.LoadScene("Quest");
    }
}
