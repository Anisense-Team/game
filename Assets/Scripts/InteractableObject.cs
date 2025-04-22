using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public MonoBehaviour interactionBehavior;

    public string GetPrompt()
    {
        if (interactionBehavior is IInteractable i) 
            return i.GetInteractPrompt();

        return "";
    }

    public void Interact()
    {
        if (interactionBehavior is IInteractable i)
            i.Interact();
    }
}
