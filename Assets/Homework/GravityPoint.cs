using UnityEngine;

public class GravityPoint : MonoBehaviour
{ 
    [SerializeField] float gravity;
     
    Rigidbody rigidB;

    private void Start()
    {
        rigidB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 selfP = transform.position;

        foreach (GravityPoint gp in FindObjectsOfType<GravityPoint>())
        {
            if (gp == this)
                continue;

            Vector3 p = gp.transform.position;
            Vector3 distanceVec = p - selfP;

            if (distanceVec == Vector3.zero)
                continue;

            float sqrDistance = distanceVec.sqrMagnitude;
            rigidB.velocity += distanceVec.normalized * (rigidB.mass * gp.rigidB.mass * gravity * Time.fixedDeltaTime / sqrDistance);
        }
    }

    void Update()
    {
        transform.position += rigidB.velocity * Time.deltaTime;
    }

}
