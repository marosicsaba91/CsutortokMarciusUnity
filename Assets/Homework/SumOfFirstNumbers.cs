using UnityEngine;

class SumOfFirstNumbers : MonoBehaviour
{
    [SerializeField, Min(0)] int number;

    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= number; i++) 
        {
            sum += i;
        }
        Debug.Log(sum);
    }
}
