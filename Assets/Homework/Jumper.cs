using UnityEngine;

class Jumper : MonoBehaviour
{
    [SerializeField] float speed = 5;

    Vector3 targetPos;

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        Vector3 input = GetInputDirection();

        if(input != Vector3.zero)
            targetPos += input;

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }



    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D);
        bool leftButton = Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A);
        bool upButton = Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
        bool downButton = Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S);

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= 1;
        }

        float y = 0;
        if (upButton)
        {
            y += 1;
        }
        if (downButton)
        {
            y -= 1;
        }

        Vector3 jump = new Vector3(x, y, 0);
        return jump.normalized;
    }
}
