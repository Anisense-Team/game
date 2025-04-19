using UnityEngine;

public class ResourceChunkSpawner : MonoBehaviour
{
    public GameObject resourceOrbPrefab;
    public float scatterRadius = 0.5f;
    public float lifetime = 4f;

    public void Spawn(ResourceType type, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 offset = Random.insideUnitSphere * scatterRadius;
            Vector3 spawnPos = transform.position + offset;
            GameObject orb = Instantiate(resourceOrbPrefab, spawnPos, Quaternion.identity);

            Renderer renderer = orb.GetComponent<Renderer>();
            if (renderer != null )
            {
                renderer.material.color = GetColorByResource(type);
            }

            Destroy(orb, lifetime);
        }
    }

    private Color GetColorByResource(ResourceType type)
    {
        return type switch
        {
            ResourceType.Iron => Color.gray,
            ResourceType.Copper => new Color(0.8f, 0.5f, 0.2f),
            ResourceType.HydrogenIce => Color.cyan,
            ResourceType.Silicon => Color.blue,
            ResourceType.Titanium => Color.white,
            ResourceType.Tungsten => Color.black,
            ResourceType.Brainium => Color.magenta,
            _=> Color.green,
        };
    }
}
