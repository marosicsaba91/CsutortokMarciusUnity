using UnityEngine;

public class SmallestCommon : MonoBehaviour
{
    int SmallestCommonMultiplier(int a, int b) 
    {
        int max = Mathf.Max(a, b);

        bool da, db;

        int v = max;
        do
        {
            da = v % a == 0;
            db = v % b == 0;
            v++;
        } while (!da || !db);

        return v;
    }


    void NxN(int n) 
    {
        int count = 0;
        for (int i = 1; count < n; i++)
        {
            bool foundOne = SumOfDigits(i) == n;
            if (foundOne)
            {
                count++;
                Debug.Log(i);
            }
        }
    }

    int SumOfDigits(int n)
    {
        return 0;
    }

}
