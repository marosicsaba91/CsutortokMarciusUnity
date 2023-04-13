using UnityEngine;

class Circle : MonoBehaviour
{
    [SerializeField] float radius = 1;

    [SerializeField] float circumferance;
    [SerializeField] float area;

    void OnValidate()
    {
        // float pi = 3.144235346565747354555f;

        circumferance = 2 * radius * Mathf.PI;   // Kerület
        area = radius * radius * Mathf.PI;       // Terület

        // Debug.Log($"Ker: {circumferance},    Ter: {area}");
    }
}
