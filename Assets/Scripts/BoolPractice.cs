//using UnityEngine;

//public class BoolPractice : MonoBehaviour
//{
//    void Start()
//    {
//        bool b1 = true;
//        bool b2 = false;

//        b1 = false;

//        int i1 = 33, i2 = 33;

//        bool intsAreEqual = i1 == i2;     // True
//        bool i1IsHigherThanI2 = i1 > i2;  // False
//        bool i1IsLowerThanI2 = i1 < i2;   // False

//        bool i1IsHigherOrEqualThanI2 = i1 >= i2;  // True
//        bool i1IsLowerOrEqualThanI2 = i1 <= i2;   // True

//        bool intsAreNotEqual = i1 != i2;     // False

//        bool stringsAreEqual = "aaaa" == "AAAA";       // False
//        bool stringsAreNotEqual = "aaaa" != "AAAA";    // True

//        // --------------------------------------

//        int ammo = 50;
//        bool isAlive = true;

//        bool haveAmmo = ammo > 0;

//        bool canShoot = isAlive && haveAmmo;

//        float height = 12;
//        bool canAirJump = false;

//        bool canJump = canAirJump || height == 0;   // false

//        bool isInAir = height > 0;
//        bool isGrounded = !isInAir;

//        canJump = canAirJump || !isInAir;   // false


//        bool b3 = b1 ^ b2;  // XOR = Kizáró vagy
//    }
//}
