using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;

    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        transform.position = Vector3.MoveTowards( selfPoint, targetPoint, speed * Time.deltaTime);
    }
}
