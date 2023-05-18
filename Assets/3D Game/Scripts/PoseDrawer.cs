using UnityEngine;

public class PoseDrawer : MonoBehaviour
{
    void OnDrawGizmos()
    {

        Vector3 center = transform.position;

        Vector3 a = center + transform.right;
        Vector3 b = center - transform.right;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(a, b);
        Gizmos.DrawSphere(a, 0.2f);

        a = center + transform.up;
        b = center - transform.up;
        Gizmos.color = Color.green;
        Gizmos.DrawLine(a, b);
        Gizmos.DrawSphere(a, 0.2f);

        a = center + transform.forward;
        b = center - transform.forward;
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(a, b);
        Gizmos.DrawSphere(a, 0.2f);

    }
}
