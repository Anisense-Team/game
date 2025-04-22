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

        if (Physics.Raycast(ray, out hit, interactRange, asteroidLayer))
        {
            Harvestable target = hit.collider.GetComponent<Harvestable>();
            if (target != null)
            {
                if (target != currentTarget)
                {
                    currentTarget = target;
                    holdTimer = 0f;
                }

                if (Input.GetKey(KeyCode.Mouse0))
                {
                    holdTimer += Time.deltaTime;

                    if (holdTimer >= currentTarget.harvestTime)
                    {
                        Asteroid asteroid = currentTarget.GetComponent<Asteroid>();
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