using System;
using UnityEngine;

public class GameWorldManager : MonoBehaviour
{
    public static GameWorldManager Instance { get; private set; }

    public GameSaveData CurrentData;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        InitializeGameWorld();
    }

    void InitializeGameWorld()
    {
        if (SaveManager.SaveExists)
        {

        }
    }
}
