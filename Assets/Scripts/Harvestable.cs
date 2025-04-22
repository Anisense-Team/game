using UnityEngine;

public class Harvestable : MonoBehaviour
{
    // IN THE FUTURE SET THIS DEPENDING ON OBJECT SIZE
    public float harvestTime = 3f;
    public float interactRange = 5f;

    [HideInInspector] public bool isInRange = false;
}