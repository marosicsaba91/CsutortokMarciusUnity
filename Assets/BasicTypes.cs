using UnityEngine;

class BasicTypes : MonoBehaviour
{
    [SerializeField, Min(10)] int intField = 5;
    [SerializeField, Range(0,10)] float floatField = 7.77f;
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true;
    bool myBoolField = true;

    void Start()
    {

        int i = 4;
        float f = 1.54f;
        string s = "Ez az elsõ string-em";
        bool b1 = true;
        bool b2 = false;

        var v1 = "string";
        var v2 = 12.5f;
        var v3 = 56;
        var v4 = false;

        // ---------------------------------------

        float f1 = f + 4;
        float f2 = f1 - f;
        float f3 = f2 * f;
        float f4 = f2 / f;
        float f5 = f2 % f;

        float f6 = 3 / 2f;   // Pontos

        int i1 = 3, i2 = 2;

        float f7 = i1 / (float) i2;  // Pontos

        double d = 23.5678;    // Kiegészítõ
        long l = 124656;       // 

        float f8 = (float) 5;
        int i3 = (int) 34.56f;

        // -------------------------------------------

        string s2 = s + "Akármi";
        string s3 = s2 + 15;

        Debug.Log(s3); // Kiiratás

        string s4 = "A korom: " + f1 + " A magasságom: " + f2;
        string s5 = $"A korom {f1}, A magasságom: {f2}   \n  \t  \\   {{   ghgtf    }}";

        string s6 = f7.ToString();
        string s7 = "76";

        int i4 = int.Parse(s7);  // Nem Garantált
    }
}
