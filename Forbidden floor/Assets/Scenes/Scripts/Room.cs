using UnityEngine;

public class Room : MonoBehaviour
{

    public GameObject doorNorth;
    public GameObject doorSouth;
    public GameObject doorWest;
    public GameObject doorEast;

    public void RotateRandomly()
    {
        int count = Random.Range(0, 4);
        for (int i = 0; i < count; i++)
        {
            transform.Rotate(0, 90, 0);

            GameObject tmp = doorNorth;
            doorNorth = doorWest;
            doorWest = doorSouth;
            doorSouth = doorEast;
            doorEast = doorNorth;
            doorNorth = tmp;
        }

    }
}
