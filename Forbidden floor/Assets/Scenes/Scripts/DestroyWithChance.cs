using UnityEngine;

public class DestroyWithChance : MonoBehaviour
{
    [Range(0, 1)]
    public float chanceOfDestruction = 0.5f;

    private void Start()
    {
        if (Random.value < chanceOfDestruction)
        {
            Destroy(gameObject);
        }
    }
}
