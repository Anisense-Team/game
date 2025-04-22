using System.Collections.Generic;
using UnityEngine;

public class ShipResourceManager : MonoBehaviour
{
    private Dictionary<ResourceType, int> _resources = new();

    private void Awake()
    {
        foreach (ResourceType type in System.Enum.GetValues(typeof(ResourceType)))
        {
            _resources[type] = 0;
        }
    }

    public void AddResource(ResourceType type, int amount)
    {
        _resources[type] += amount;
    }

    public int GetResourceAmount(ResourceType type)
    {
        return _resources.TryGetValue(type, out int amount) ? amount : 0;
    }

    public bool ConsumeResource(ResourceType type, int amount)
    {
        if (_resources.TryGetValue(type, out int current) && current >= amount)
        {
            _resources[type] -= amount;
            return true;
        }

        return false;
    }
}