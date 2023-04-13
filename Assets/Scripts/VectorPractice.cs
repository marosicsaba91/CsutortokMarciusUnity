using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 v2;
        Vector3 v3;

        v2 = new Vector2 (3, 7);
        v3 = new Vector3 (3, 7, 6);

        v3 = new Vector3();      // X, Y, Z = 0
        v3 = new Vector3(1,2);   // Z = 0

        v3 = Vector3.zero;       // X, Y, Z = 0
        v3 = Vector3.one;        // X, Y, Z = 1
                                 
        // Egységvektorok:
        v3 = Vector3.right;      // X = 1,  Y = 0,  Z = 0
        v3 = Vector3.left;       // X = -1, Y = 0,  Z = 0
        v3 = Vector3.up;         // X = 0,  Y = 1,  Z = 0
        v3 = Vector3.down;       // X = 0,  Y = -1, Z = 0
        v3 = Vector3.forward;    // X = 0,  Y = 0,  Z = 1
        v3 = Vector3.back;       // X = 0,  Y = 0,  Z = -1

        // Mûveletek

        Vector3 vSum = v3 + new Vector3(1, 2, 3);
        Vector3 vDif = vSum - Vector3.left;
        Vector3 vMult = v3 * 10;
        Vector3 vDiv = vSum / 10;

        float length = v3.magnitude;
        Vector3 normalized = v3.normalized;

        v3.Normalize();

        //
        float x = v3.x;
        float y = v3.y;
        float z = v3.z;
    }
}