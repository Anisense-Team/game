using UnityEngine;

public class BeerTapHandle : MonoBehaviour, IInteractable
{
    public ParticleSystem beerStream;
    public AudioSource pourSound;
    public float fillRate = 10f;

    private bool isPouring = false;

    public string GetInteractPrompt()
    {
        return isPouring ? "Release Tap" : "Pull Tap";
    }

    public void Interact()
    {
        if (isPouring)
            StopPouring();
        else
            StartPouring();
    }

    private void Update()
    {
        if (isPouring)
        {
            // Raycast straight down to detect a Fillable glass
            if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 2f))
            {
                Fillable glass = hit.collider.GetComponent<Fillable>();
                if (glass != null)
                {
                    FillGlass(glass);
                }
            }
        }
    }

    private void FillGlass(Fillable glass)
    {
        if (!glass.IsFull)
        {
            glass.Fill(Time.deltaTime * fillRate);
        }
        else
        {
            Debug.Log("Glass is full!");
            StopPouring();
        }
    }

    private void StartPouring()
    {
        isPouring = true;

        if (beerStream != null) beerStream.Play();
        if (pourSound != null) pourSound.Play();

        // Optional: rotate tap handle down, play animation
    }

    private void StopPouring()
    {
        isPouring = false;

        if (beerStream != null) beerStream.Stop();
        if (pourSound != null) pourSound.Stop();

        // Optional: rotate tap handle up
    }
}
