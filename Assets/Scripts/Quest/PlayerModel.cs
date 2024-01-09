using System;
using UnityEngine;

[Serializable]
public class PlayerModel
{
    static PlayerModel instance = null;

    static public PlayerModel GetInstande()
    {
        if (instance == null)
        {
            instance = new PlayerModel();
        }
        return instance;
    }

    [SerializeField]
    private int maxHp;
    [SerializeField]
    private int hp;
    [SerializeField]
    private int atk;
    [SerializeField]
    private int currentStage;

    public int MaxHp
    {
        get {return maxHp;}
    }
    public int HP
    {
        get {return hp;}
    }
    public int Atk
    {
        get {return atk;}
    }
    public int CurrentStage
    {
        get {return currentStage;}
    }

    public PlayerModel()
    {
        maxHp = 100;
        hp = maxHp;
        atk = 6;
        currentStage = 0;
    }

    public void AttackTo(MonsterModel monsterModel)
    {
        Debug.Log("モンスターを攻撃");
        monsterModel.Damage(atk);
    }

    public void Damage(int damage)
    {
        Debug.Log("ダメージを受ける");
        // ダメージ処理の最大最小を設定
        hp = Mathf.Clamp(hp - damage, 0, maxHp);
    }

    public void UppAttackPoint()
    {
        atk += 2;
    }

    public void NextStage()
    {
        currentStage++;
    }
    public void BackTown()
    {
        currentStage = 0;
    }

    string SAVELEY  = "PLAYER-SAVE-KEY";

    public void Save()
    {
        PlayerPrefs.SetString(SAVELEY, JsonUtility.ToJson(this));
        PlayerPrefs.Save();
    }

    public void Load()
    {
        string jsonPlayer = PlayerPrefs.GetString(SAVELEY, JsonUtility.ToJson(new PlayerModel()));
        instance = JsonUtility.FromJson<PlayerModel>(jsonPlayer);
    }

    public void DeleteSaveData()
    {
        PlayerPrefs.DeleteKey(SAVELEY);
        PlayerPrefs.Save();
        Load();
    }
}
