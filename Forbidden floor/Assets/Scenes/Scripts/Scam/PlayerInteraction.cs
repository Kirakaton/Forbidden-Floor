using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance = 3f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(
                new Vector3(Screen.width / 2f, Screen.height / 2f));

            if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
            {
                Debug.Log("Луч попал в: " + hit.collider.gameObject.name);

                DirtyObject dirty = hit.collider.GetComponent<DirtyObject>();

                if (dirty != null)
                {
                    dirty.Clean();
                }
                else
                {
                    Debug.Log("DirtyObject не найден на объекте");
                }
            }
            else
            {
                Debug.Log("Луч ни во что не попал");
            }
        }
    }
}