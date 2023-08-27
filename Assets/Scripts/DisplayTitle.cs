using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTitle : MonoBehaviour
{
    Text title;
    // Start is called before the first frame update
    void Start()
    {
        title = GetComponent<Text>();
        loadHighScore();
    }
    private void Update()
    {
        //if(PersistentManager.Instance.namePlayer != "" && PersistentManager.Instance.highScore != 0)
        //{
        //    loadHighScore();
        //}
    }

    void loadHighScore()
    {
        PersistentManager.Instance.LoadPLayerInfo();
        title.text = "Best Score: " + PersistentManager.Instance.namePlayer + ": " + PersistentManager.Instance.highScore.ToString();
    }
}
