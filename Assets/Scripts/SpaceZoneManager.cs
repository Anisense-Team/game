using System;
using UnityEngine;

public class SpaceZoneManager : MonoBehaviour
{
    public static SpaceZoneManager Instance { get; private set; }

    public SpaceZoneState CurrentState { get; private set; }

    public event Action<SpaceZoneState> OnZoneStateChanged;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    public void SetZoneState(SpaceZoneState newState)
    {
        if (newState == CurrentState) return;
        CurrentState = newState;
        OnZoneStateChanged?.Invoke(newState);
        Debug.Log($"Zone state changed to: {newState}");
    }

    public float GetAsteroidSpawnChance()
    {
        return CurrentState switch
        {
            SpaceZoneState.AsteroidField => 0.85f,
            SpaceZoneState.Doldrums => 0.85f,
            _ => 0.5f
        };
    }
}
