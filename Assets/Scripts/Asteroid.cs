using Unity.VisualScripting;
using UnityEngine;

//!!IMPORTANT
//This SHOUD HAVE A MAXIUMUM AMOUNT OF RESOURCES IT CAN HAVE IN IT, ALSO THERE SHOULD PROBABLY BE AN ENUM FOR ASTROID SIZES (SMALL, MEDIUM, LARGE, XLARGE)
//!!IMPORTANT

public class AsteroidStateManager : MonoBehaviour
{
    [Header("Drop Ranges")]
    public Vector2Int ironRange = new Vector2Int(3, 7);
    public Vector2Int copperRange = new Vector2Int(2, 5);
    public Vector2Int hydrogenIceRange = new Vector2Int(1, 4);

    private bool harvested = false;

    public ResourceChunkSpawner spawner;

    public void Harvest(ShipResourceManager ship)
    {
        if (harvested) return;

        harvested = true;

        int iron = Random.Range(ironRange.x, ironRange.y + 1);
        int copper = Random.Range(copperRange.x, copperRange.y + 1);
        int hydrogenIce = Random.Range(hydrogenIceRange.x, hydrogenIceRange.y + 1);

        ship.AddResource(ResourceType.Iron, iron);
        ship.AddResource(ResourceType.Copper, copper);
        ship.AddResource(ResourceType.HydrogenIce, hydrogenIce);

        if (spawner != null)
        {
            spawner.Spawn(ResourceType.Iron, iron, transform.position);
            spawner.Spawn(ResourceType.Copper, copper, transform.position);
            spawner.Spawn(ResourceType.HydrogenIce, hydrogenIce, transform.position);
        }

        Destroy(gameObject);
    }
}