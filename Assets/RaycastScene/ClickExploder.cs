using System;
using UnityEngine;

class ClickExploder : MonoBehaviour
{
    [SerializeField] Transform cursorTransform;
    [SerializeField] LayerMask clickMask;

    [SerializeField] float range = 10;
    [SerializeField] float maxImpulse = 10;

    ParticleSystem particleSys;
    AudioSource audioSource;
    Renderer cursorRenderer;

    void Start()
    {
        particleSys = cursorTransform.GetComponent<ParticleSystem>();
        cursorRenderer = cursorTransform.GetComponent<Renderer>();
        audioSource = cursorTransform.GetComponent<AudioSource>();

    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay( mousePos );

        bool isHit = Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, clickMask);

        // cursorTransform.gameObject.SetActive(isHit);
        cursorRenderer.enabled = isHit;

        if (isHit)
        {
            // Debug.Log($"Hit:  {hit.collider.name}   -   {hit.point}");
            cursorTransform.position = hit.point;

            if (Input.GetMouseButtonDown(0)) 
            {
                Explode(hit.point);
            }
        }
    }

    void Explode(Vector3 point)
    {
        audioSource.volume += 0.1f;

        particleSys.Play();
        audioSource.Play();

        Rigidbody[] allRigidBodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in allRigidBodies)
        {
            Vector3 distanceVector = rb.position - point;
            float distance = distanceVector.magnitude;
            if (distance > range)
                continue;

            // Ellökés:
            Vector3 direction = distanceVector / distance;
            float m = 1 - (distance / range);
            float impulse = maxImpulse * m;

            rb.AddForce(direction * impulse, ForceMode.Impulse);
            // rb.velocity += direction * impulse / rb.mass;

        }
        
    }
}
