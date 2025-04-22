using System;
using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour 
{
    [Header("Spawn Timing")]
    public float checkInterval = 8f;
    
    private bool asteroidInZone = false;

    // Event for terminals and bots to subscribe to :)
    public event Action OnAsteroidEnteredZone;

    private void Start()
    {
        StartCoroutine(ZoneCheckLoop());
    }

    IEnumerator ZoneCheckLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(checkInterval);

            if (asteroidInZone)
            {
                float spawnChance = SpaceZoneManager.Instance.GetAsteroidSpawnChance();

                if (UnityEngine.Random.value < spawnChance)
                {
                    asteroidInZone = true;
                    OnAsteroidEnteredZone?.Invoke();
                    Debug.Log("[AsteroidSpawner] Asteroid has entered the zone!");
                }
            }
        }
    }

    public bool isAsteroidInZone()
    {
        return asteroidInZone;
    }

    public void ClearZone()
    {
        asteroidInZone = false;
    }
}
