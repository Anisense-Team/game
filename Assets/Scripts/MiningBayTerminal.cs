using UnityEngine;

public class MiningBayTerminal : MonoBehaviour, IInteractable
{
    public GameObject terminalUI;

    public string GetInteractPrompt() => "[E] to access Terminal";

    public void Interact()
    {
        terminalUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    public void CloseTerminal()
    {
        terminalUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
