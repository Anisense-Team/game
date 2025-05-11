using UnityEngine;

public class Fillable : MonoBehaviour
{
    public float currentAmount = 0f;
    public float maxAmount = 100f;

    public bool IsFull => currentAmount >= maxAmount;

    public void Fill(float amount)
    {
        currentAmount = Mathf.Min(currentAmount + amount, maxAmount);
    }
}
