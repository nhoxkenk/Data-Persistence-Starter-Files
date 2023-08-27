using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    public static PersistentManager Instance;

    public string namePlayer = "";
    public int highScore = 0;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        //LoadPLayerName();
    }

    [System.Serializable]
    class SaveData
    {
        public string namePlayer;
        public int highScore;
    }

    public void SavePlayerInfo()
    {
        SaveData data = new SaveData();
        data.namePlayer = namePlayer;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPLayerInfo()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            namePlayer = data.namePlayer;
            highScore = data.highScore;
        }
    }
}
