using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatusView : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI hpText;
    [SerializeField]
    TextMeshProUGUI atkText;

    /// <summary>
    /// QuestPresenterから呼び出される
    /// </summary>
    /// <param name="hp"></param>
    /// <param name="maxHp"></param>
    /// <param name="atk"></param>
    public void UpdateText(int hp,int maxHp, int atk)
    {
        hpText.text = string.Format("HP: {0}/{1}", hp, maxHp);
        atkText.text = string.Format("ATK: {0}", atk);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
