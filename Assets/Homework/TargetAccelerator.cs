using System.Collections.Generic;
using UnityEngine;

class TargetAccelerator : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float range;
    [SerializeField] float acceleration;
    [SerializeField] float deceleration;

    Vector3 velocity;
    List<Vector3> list = new List<Vector3>();

    void FixedUpdate()
    {
        list.Clear();
        for (int i = 0; i < 100; i++)
        {
            list.Add(Vector3.up);
        }

        Vector3 distanceVector = target.position - transform.position;
        float distance = distanceVector.magnitude;
        Vector3 direction = distanceVector / distance;

        if (distance > range)
        {
            velocity += acceleration * direction * Time.fixedDeltaTime;
        }
        else 
        {
            velocity = Vector3.MoveTowards(velocity, Vector3.zero, deceleration * Time.fixedDeltaTime);
        }
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }


    void OnDrawGizmos()
    {
        if (target == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(target.position, range);
    }

}
