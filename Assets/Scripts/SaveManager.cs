using System.IO;
using System.Linq;
using UnityEngine;

public static class SaveManager
{
    private static string SaveDirectory => Path.Combine(Application.persistentDataPath);

    public static void SaveGame(GameSaveData data)
    {
        string timestamp = System.DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        string fileName = $"save_{timestamp}.json";
        string fullPath = Path.Combine(SaveDirectory, fileName);

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(fullPath, json);

        Debug.Log($"Game saved to {fullPath}");
    }

    public static GameSaveData LoadLatestSave()
    {
        var files = Directory.GetFiles(SaveDirectory, "save_*.json");
        if (files.Length == 0) return null;

        string latestFile = files.OrderByDescending(f => File.GetLastWriteTime(f)).First();
        string json = File.ReadAllText(latestFile);
        return JsonUtility.FromJson<GameSaveData>(json);
    }
}
