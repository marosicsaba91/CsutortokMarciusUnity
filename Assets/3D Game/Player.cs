using UnityEngine;

class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void Start() { }


    void Update()
    {
        Vector3 direction = GetInputDirection();
        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }

    Vector3 GetInputDirection() 
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow);
        bool upButton = Input.GetKey(KeyCode.UpArrow);
        bool downButton = Input.GetKey(KeyCode.DownArrow);

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= 1;
        }

        float z = 0;
        if (upButton)
        {
            z += 1;
        }
        if (downButton)
        {
            z -= 1;
        }

        Vector3 d = new Vector3(x, 0, z);
        d.Normalize();
        return d;
    }

}
