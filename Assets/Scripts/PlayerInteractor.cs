using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractor : MonoBehaviour
{
    public float interactRange = 3f;
    public KeyCode interactKey = KeyCode.E;
    public TextMeshProUGUI interactPromptUI;

    private InteractableObject currentInteractable;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        Debug.DrawRay(transform.position, transform.forward * interactRange, Color.green);

        if (Physics.Raycast(ray, out RaycastHit hit, interactRange))
        {
            currentInteractable = hit.collider.GetComponent<InteractableObject>();

            if (currentInteractable != null)
            {
                interactPromptUI.text = currentInteractable.GetPrompt();
                interactPromptUI.enabled = true;

                if (Input.GetKeyDown(interactKey))
                {
                    currentInteractable.Interact();
                }

                return;
            }
        }

        interactPromptUI.enabled = false;
        currentInteractable = null;
    }
}
