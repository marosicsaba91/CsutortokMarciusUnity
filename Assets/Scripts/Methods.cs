using UnityEngine;

class Methods : MonoBehaviour
{
    void Start()
    {
        int a = -45;

        int abs = Mathf.Abs(a);
        int min = Mathf.Min(a, 10);
        int max = Mathf.Max(a, 10, -5, 4);

        int myAbs;
        if (a < 0)
        {
            myAbs = -a;
        }
        else 
        {
            myAbs = a;
        }

        int myAbs2 = MyAbs(myAbs);
        int myAbs3 = MyAbs(-6);
        int myAbs4 = MyAbs(555);

        float power = Mathf.Pow(23.5f, 4.5f);
        float power2 = MyPow(23, (int) 4.5f);

        float sign = Mathf.Sign(-254);

        MultiplicationTable(10);
        MultiplicationTable(3);
        MultiplicationTable(100);

        float f;

        f = Mathf.Clamp(power, -10, 10);
        f = Mathf.Clamp01(power2);
        f = Mathf.Ceil(f);
        f = Mathf.Floor(f);
        f = Mathf.Round(f);
        int i;
        i = Mathf.CeilToInt(f);
        i = Mathf.FloorToInt(f);
        i = Mathf.RoundToInt(f);

        f = Mathf.Pow(f, 5);
        f = Mathf.Sqrt(f);
        f = Mathf.Pow(f, 1/3f);  // Köbgyök

    }

    int MyAbs(int num) 
    {
        int myAbs;
        if (num < 0)
        {
            myAbs = -num;
        }
        else
        {
            myAbs = num;
        }
        return myAbs;
    }

    float MyPow(float baseNumber, int exponent) 
    {
        float result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    float MySign(float number)
    {
        if (number < 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }    
    }

    void MultiplicationTable(int number) 
    {
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                string s = $"{j} * {i} = {i * j}";
                Debug.Log(s);                
            }
        }
    }

}
