using System;
using TMPro;
using UnityEngine;

public class MonsterView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI hpText;

    private Action onTap;

    public void UpdateHPText(MonsterModel monsterModel)
    {
        hpText.text = string.Format("HP {0}/{1}", monsterModel.HP, monsterModel.MaxHp);
    }

    public void AddListenerOnTap(Action action)
    {
        onTap += action;
    }

    public void OnTap()
    {
        Debug.Log("Monsterをタップしたよ！");
        onTap();
    }
}
