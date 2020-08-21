using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private const string High_Score = "High Score";

    void Awake()
    {
        _MakeSingleInstance();
        IsGameStartedForTheFirstTime();
    }

    void IsGameStartedForTheFirstTime()
    {
        if(!PlayerPrefs.HasKey ("IsGameStartedForTheFirstTime"))
        {
            PlayerPrefs.SetInt(High_Score, 0);
            PlayerPrefs.SetInt("IsGameStartedForTheFirstTime", 0);
        }
    }

    void _MakeSingleInstance()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetHighScore(int score)
    {
        PlayerPrefs.SetInt(High_Score, score);
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(High_Score);
    }
}
