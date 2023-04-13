using UnityEngine;

class MyPower : MonoBehaviour
{
    [SerializeField] int baseNumber;
    [SerializeField] int exponent;

    void Start()
    {
        int m = 1;
        for (int i = 0; i < exponent; i++)
        {
            m *= baseNumber;
        }
        Debug.Log(m);
    }

}
