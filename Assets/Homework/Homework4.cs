using UnityEngine;

public class Homework4 : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int sumOfDigits;


    [SerializeField] int[] intArray;
    [SerializeField] int[] reversed;

    // [SerializeField] int[] testArray;
    [SerializeField] int fibonycciLength;
    [SerializeField] int[] fibonacciArray;

    [SerializeField] Vector2 a, b;
    [SerializeField] int jumpCount;
    [SerializeField] Vector2 oneJump;

    void OnValidate()
    {
        sumOfDigits = SumOfDigits(number);
        reversed = ReverseArray(intArray);

        // ReverseThisArray(testArray);
        fibonacciArray = Fibonacci(fibonycciLength);

        // -----------------------------

        Vector2 distanceVec = b - a;
        float fullLength = distanceVec.magnitude;
        jumpCount = Mathf.CeilToInt( fullLength );
        oneJump = distanceVec / jumpCount;

    }

    int SumOfDigits(int n)
    {
        int sum = 0;
        do
        {
            int last = n % 10;
            sum += last;
            n = n / 10;

        } while (n != 0);

        return sum;
    }

    int[] ReverseArray(int[] original) 
    {
        if (original == null)
            return null;

        int l = original.Length;
        int[] result = new int[l];

        for (int i = 0; i < l; i++)
        {
            int element = original[i];
            result[l - i - 1] = element;
        }

        return result;
    }


    void ReverseThisArray(int[] original)
    {
        if (original == null)
            return;

        int l = original.Length;

        for (int i = 0; i < l/2; i++)
        {
            int element = original[i];
            original[i] = original[l - i - 1];
            original[l - i - 1] = element;
        }
    }

    int[] Fibonacci(int n) 
    {
        int[] result = new int[n];

        if (n >= 1)
            result[0] = 0;

        if (n >= 2)
            result[1] = 1;

        for (int i = 2; i < n; i++)
        {
            result[i] = result[i - 1] + result[i - 2];
        }

        return result;
    }
}
