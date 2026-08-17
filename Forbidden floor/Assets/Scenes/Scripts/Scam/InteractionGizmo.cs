using UnityEngine;

public class InteractionGizmo : MonoBehaviour
{
    public float interactDistance = 3f;

    private void OnDrawGizmos()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        bool hit = Physics.Raycast(ray, out RaycastHit hitInfo, interactDistance);

        if (hit)
        {
            // Зелёная линия до точки попадания
            Gizmos.color = Color.green;
            Gizmos.DrawLine(ray.origin, hitInfo.point);

            // Красная сфера в точке попадания
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(hitInfo.point, 0.08f);
        }
        else
        {
            // Жёлтая линия если ничего не попало
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(ray.origin, ray.origin + transform.forward * interactDistance);
        }

        // Белая сфера — начало луча (позиция камеры)
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(ray.origin, 0.05f);
    }
}