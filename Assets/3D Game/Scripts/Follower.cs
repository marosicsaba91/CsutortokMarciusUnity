using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance;

    void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;

        float distance = Vector3.Distance(targetPoint, selfPoint);
        float speedMultiplier = speedOverDistance.Evaluate(distance);

        float step = speed * speedMultiplier * Time.deltaTime;

        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, step);
    }
}
