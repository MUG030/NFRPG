using UnityEngine;

public class StageView : MonoBehaviour
{
    [SerializeField]
    GameObject monsterViewPrefab;

    public MonsterView SpawnMonster()
    {
        GameObject monster = Instantiate(monsterViewPrefab);
        monster.transform.SetParent(this.transform, false);
        return monster.GetComponent<MonsterView>();
    }
}
