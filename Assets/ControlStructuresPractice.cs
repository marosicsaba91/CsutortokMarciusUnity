using UnityEngine;

class ControlStructuresPractice : MonoBehaviour
{
    [SerializeField] int a, b;

    void Start()
    {
        //if (a > b)
        //{
        //    Debug.Log("A nagyobb, mint B.");
        //}
        //else if (a < b)
        //{
        //    Debug.Log("A kisebb, mint B.");
        //}
        //else
        //{
        //    Debug.Log("A és B egyenlõ.");
        //}


        //// ---------------

        //if (a % 2 == 0)
        //{
        //    Debug.Log("A Páros");
        //}
        //else
        //{
        //    Debug.Log("A Páratlan");
        //}

        //// -------------------

        //bool aDevidableB = a % b == 0;

        //if (aDevidableB)
        //{
        //    Debug.Log("A osztható B-val");
        //}


        //bool bDevidableA = b % a == 0;
        //if (bDevidableA)
        //{
        //    Debug.Log("B osztható A-val");
        //}

        //if (!aDevidableB && !bDevidableA)
        //{
        //    Debug.Log("A és B nem oszthatók egymással.");
        //}

        //// -----------------------

        //int number = 12354;
        //int lastDigit = number % 10;

        //switch (lastDigit)
        //{
        //    case 1:
        //        Debug.Log("Egy");
        //        break;
        //    case 2:
        //        Debug.Log("Kettõ");
        //        break;
        //    //...
        //    case 9:
        //        Debug.Log("Kilenc");
        //        break;
        //    default:
        //        Debug.Log("Nulla");
        //        break;
        //}

        //// ----------------------


        //string pairity;
        //if (number % 2 == 0)
        //{
        //    pairity = "páros";
        //}
        //else
        //{
        //    pairity = "páratlan";
        //}

        //pairity = number % 2 == 0 ? "páros" : "páratlan";


        //// ----------------------------------------------


        //int i = 1;
        //while (i <= 100)
        //{
        //    Debug.Log(i);
        //    i++;
        //}

        // -------------------------------------------------

        int i = 1;
        int count = 0;

        while (count < 100)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }

        // ---------------------------------------------------

        do
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }
        while (count < 100);

        // -------------------------------------------------------

        int b = 12;

        for (int j = 0; j < 100; j++)
        {
            // Debug.Log(a);    // ERROR
            Debug.Log(b);    // OK

            int a = 5;

            Debug.Log(a);    // OK
            Debug.Log(b);    // OK
            if (true)
            {
                Debug.Log(a);    // OK
                Debug.Log(b);    // OK
            }
        }

        // Debug.Log(a); //  ERROR
        Debug.Log(b); //  OK 

    }

}
