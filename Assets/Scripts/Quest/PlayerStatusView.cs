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
    /// <param name="playerModel"></param>
    public void UpdateText(PlayerModel playerModel)
    {
        hpText.text = string.Format("HP: {0}/{1}", playerModel.HP, playerModel.MaxHp);
        atkText.text = string.Format("ATK: {0}", playerModel.Atk);
    }
}
