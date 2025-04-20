using UnityEngine;

public class ResourceChunkSpawner : MonoBehaviour
{
    public GameObject resourceOrbPrefab;
    public float scatterRadius = 0.5f;

    public float MIN_CHUNK_SIZE = 0.1f;
    public float MAX_CHUNK_SIZE = 0.4f;

    public float MIN_CHUNK_FLING_FORCE = 1f;
    public float MAX_CHUNK_FLING_FORCE = 3f;

    public float MIN_CHUNK_LIFETIME = 3.5f;
    public float MAX_CHUNK_LIFETIME = 5.5f;

    public void Spawn(ResourceType type, int amount, Vector3 asteroidPosition)
    {
        for (int i = 0; i < amount; i++)
        {
            Vector3 offset = Random.insideUnitSphere * scatterRadius;
            Vector3 spawnPos = asteroidPosition + offset;
            GameObject orb = Instantiate(resourceOrbPrefab, spawnPos, Quaternion.identity);

            float scale = Random.Range(MIN_CHUNK_SIZE, MAX_CHUNK_SIZE);
            orb.transform.localScale = Vector3.one * scale;

            Renderer renderer = orb.GetComponent<Renderer>();
            if (renderer != null )
            {
                renderer.material.color = GetColorByResource(type);
            }

            Rigidbody rb = orb.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 force = Random.onUnitSphere * Random.Range(MIN_CHUNK_FLING_FORCE, MAX_CHUNK_FLING_FORCE);
                rb.AddForce(force, ForceMode.Impulse);
            }

            float lifetime = Random.Range(MIN_CHUNK_LIFETIME, MAX_CHUNK_LIFETIME);

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
