using UnityEngine;

public class Homework5 : MonoBehaviour
{
    [SerializeField] string[] one = new string[0];
    [SerializeField] string[] other = new string[0];
    [SerializeField] string[] unitfied;

    void OnValidate()
    {
        if(one != null && other != null)
            unitfied = Unify(one, other);
    }

    string[] Unify(string[] a, string[] b) 
    {
        string[] u = new string[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
        {
            u[i] = a[i];
        }

        for (int i = 0; i < b.Length; i++)
        {
            u[i + a.Length] = b[i];
        }

        return u;
    }
}
