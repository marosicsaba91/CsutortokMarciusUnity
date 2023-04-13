using UnityEngine;

class MyFirstScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello, " + name);   // Kiíratás
        Debug.Log("I'm Csabi");        /* Kiíratás */

        int a;
        a = 10;
        a = 20;

        Debug.Log(a);

        int age = 31;
        Debug.Log(age);

        int x = 2, y = 3, z = 4;

        int v1 = x + y;    // 5
        int v2 = x - z;    // -2
        int v3 = v1 * v2;  // -10
        int v4 = y / x;    // 1

        int v5 = 15 % 4;    // 3
        int v6 = -v5;       // -3

        // ---------------

        v6 = v6 + 5;
        v6 = x - v6;


        x += 5;   // x = x + 5;
        x -= 5;   // x = x - 5;
        x *= 5;   // x = x * 5;
        x /= 5;   // x = x / 5;
        x %= 5;   // x = x % 5;


        x++;      // x += 1;     x = x+1; 
        x--;      // x = x - 1;

        // -----------------------------------

        x = 2;
        y = 6;
        z = 3;

        int v7 = x + y * z;      // 20
        int v8 = (x + y) * z;    // 24 
        int v9 = x + (y * z);    // 20

        // -------------------------------------

    }
}