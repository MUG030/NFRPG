using UnityEngine;

public class StageView : MonoBehaviour
{
    [SerializeField]
    GameObject monsterViewPrefab;

    public void SpawnMonster()
    {
        GameObject monster = Instantiate(monsterViewPrefab);
        monster.transform.SetParent(this.transform, false);
    }
}
