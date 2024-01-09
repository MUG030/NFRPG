using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterView : MonoBehaviour
{
    private Action onTap;

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
