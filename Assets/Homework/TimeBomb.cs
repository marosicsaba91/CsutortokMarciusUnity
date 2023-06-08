using UnityEngine;

class TimeBomb : MonoBehaviour
{
    [SerializeField] float duration = 5;
    [SerializeField] float range = 10;
    [SerializeField] float maxForce = 10;
    [SerializeField] float upward = 10;

    public bool isTicking = true;
    float currentTime;

    void Start()
    {
        currentTime = duration;

        // Invoke(nameof(Boom), duration);
    }

    private void Update()
    {
        if (isTicking)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
                Boom();
        }
    }

    void Boom() 
    {
        Vector3 p = transform.position;

        foreach (Rigidbody rb in FindObjectsOfType<Rigidbody>())
        {
            rb.AddExplosionForce(maxForce, p, range, upward);
            /*
            Vector3 distanceV = rb.position - p;
            float distance = distanceV.magnitude;
            if (range < distance) 
            {
                rb.AddExplosionForce(maxForce, p, range);
            }
            */
        }
    }


}
