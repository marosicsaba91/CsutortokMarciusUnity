using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] float[] testArrray;
    [SerializeField] float mean;
    [SerializeField] float max;

    void OnValidate()
    {
        mean = Mean(testArrray);
        max = Max(testArrray);

        // -----------------------

        foreach (char item in "MyString") 
        {
            Debug.Log(item);
        }

        List<int> list1 = new List<int>();
        list1.Add(201);
        list1.Add(21);
        list1.Add(12201);

        Debug.Log(list1[0]);
        list1[1] = 10;

        list1.Add(165401);
        list1[10] = 76;  // ERROR

        list1.RemoveAt(1);    // Indexen lévõ elemet
        bool success = list1.Remove(1287201);  // Kiveszek egy értéket

        list1.Insert(0, 2123421);

        list1.Clear();
        bool contains = list1.Contains(10);
        int index = list1.IndexOf(12201);

        list1.Sort();


    }

    float Mean (float n1, float n2)
    {
        return (n1 + n2) / 2;
    }

    float Mean(float n1, float n2, float n3) 
    {
        return (n1 + n2 + n3) / 3;
    }

    float Mean(params float[] array)
    {
        if (array.Length == 0)
            return 0;

        float sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            float current = array[i];
            sum += current;
        }
        return sum / array.Length;
    }

    float Max(params float[] array) 
    {
        if(array.Length == 0)
            return float.MinValue;

        float max = array[0];
        for (int i = 1; i < array.Length; i++)
        { 
            if(array[i] > max)
                max = array[i];
        }
        return max;    
    }

    float Min(params float[] array)
    {
        if (array.Length == 0)
            return float.MaxValue;

        float min = array[0];

        foreach (float f in array)
        { 
            if(f < min)
                min = f;        
        }

        return min;
    }

}
