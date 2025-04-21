using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager0421 : MonoBehaviour
{
    private static GameManager0421 instance;
    public static GameManager0421 Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject gameObject = new GameObject("GameManager");
                instance = gameObject.AddComponent<GameManager0421>();
            }
            return instance;
        }
    }

    private int gameScore = 0;
    public int GameScore { get { return gameScore; } private set { gameScore = value; } }

    private void Awake()
    {
        CreateInstance();
    }

    private void CreateInstance()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

}
