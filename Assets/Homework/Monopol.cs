using System;
using UnityEngine;

enum PoleType
{
    Positive,
    Negative
}

class Monopol : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] PoleType pole; 
    [SerializeField] float power = 1;

    void FixedUpdate()
    {
        Monopol[] all = FindObjectsOfType<Monopol>();
        Vector3 pos = transform.position;

        foreach (Monopol item in all)
        {
            if (item == this) continue;

            Vector3 distanceVec = item.transform.position - pos;

            float force = power * item.power;
            float multiplier = item.pole == pole ? 1 : -1;
            float distance = distanceVec.magnitude;


            item.AddForce(force * multiplier * distanceVec.normalized / (distance * distance));
        }
    }

    void AddForce(Vector2 vector)
    {
        rigidBody.AddForce(vector, ForceMode2D.Force);
        // rigidBody.velocity += vector * Time.fixedDeltaTime / rigidBody.mass;
    }
}
