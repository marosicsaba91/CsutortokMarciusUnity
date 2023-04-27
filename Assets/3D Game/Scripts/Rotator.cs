using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;
    [SerializeField] Vector3 axis = Vector3.up;

    void Update()
    {
        transform.Rotate(axis, angularSpeed * Time.deltaTime, space);
    }

    void OnDrawGizmos()
    {
        if (space == Space.Self)
        {
            Gizmos.matrix = transform.localToWorldMatrix;
        }


        Vector3 center = space == Space.Self ? Vector3.zero : transform.position;

        Vector3 a = center + axis.normalized;
        Vector3 b = center - axis.normalized;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(a, b);

        Gizmos.matrix = Matrix4x4.identity;
    }

}
