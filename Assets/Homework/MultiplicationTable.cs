using UnityEngine;

class MultiplicationTable : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                string s = $"{j} * {i} = {i * j}";
                Debug.Log(s);
            }
        }        
    }
}
