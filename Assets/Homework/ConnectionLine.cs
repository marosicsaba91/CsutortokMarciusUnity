using UnityEngine;

class ConnectionLine : MonoBehaviour
{
    [SerializeField] GameObject other;
    [SerializeField] float maxDistance;

    void OnDrawGizmos()
    {
        if (other == null)
            return;

        Vector3 otherPos = other.transform.position;
        Vector3 selfPos = transform.position;

        float distance = Vector3.Distance(selfPos, otherPos);

        if (distance <= maxDistance) 
        {
            Gizmos.color = distance > (maxDistance * 0.9f) ? Color.red : Color.white;
            Gizmos.DrawLine(otherPos, selfPos);
        }
    }

}
