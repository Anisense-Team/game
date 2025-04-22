using System;
using UnityEngine;

public class HarvestController : MonoBehaviour
{
    public float harvestHoldTime = 2f;
    public float interactRange = 5f;
    public LayerMask asteroidLayer;

    private float holdTimer = 0f;
    private Harvestable currentTarget = null;

    public ShipResourceManager ship;

    public Transform cameraTransform;

    void Update()
    {
        Ray ray = new Ray(cameraTransform.position, cameraTransform.forward);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * interactRange, Color.magenta);

        if (Physics.Raycast(ray, out hit, interactRange, asteroidLayer))
        {
            Harvestable target = hit.collider.GetComponent<Harvestable>();
            if (target != null)
            {
                Debug.Log("Seems there is a target");

                if (target != currentTarget)
                {
                    currentTarget = target;
                    holdTimer = 0f;
                }

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Debug.Log("Here in get mouse button");
                    holdTimer += Time.deltaTime;

                    if (holdTimer >= currentTarget.harvestTime)
                    {
                        AsteroidStateManager asteroid = currentTarget.GetComponent<AsteroidStateManager>();
                        if (asteroid != null && ship != null)
                        {
                            asteroid.Harvest(ship);
                        }

                        holdTimer = 0f;
                        currentTarget = null;
                    }
                }
                else
                {
                    holdTimer = 0f;
                }
            }
        }
        else
        {
            currentTarget = null;
            holdTimer = 0f;
        }

    }
}