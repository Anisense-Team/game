using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;


// Game Save Data will utilize semver
[System.Serializable]
public class GameSaveData
{
    public StarSystem CurrentSystem;
    public List<Robot> GamePopulation;

    public int DayNumber;
    public float BarReputation;

    public string GameVersion = GameConfig.GAME_VERSION;
    public string SaveVersion = CURRENT_SAVE_VERSION;

    public const string CURRENT_SAVE_VERSION = "1.0.0";
}
