using UnityEngine;

public class Grasshopper : MonoBehaviour
{
    [SerializeField] KeyCode upKey = KeyCode.UpArrow;
    [SerializeField] KeyCode downKey = KeyCode.DownArrow;
    [SerializeField] KeyCode rightKey = KeyCode.RightArrow;
    [SerializeField] KeyCode leftKey = KeyCode.LeftArrow;

    [SerializeField] float verticalSpeed = 5;
    [SerializeField] float horizontalSpeed = 5;
    [SerializeField] float gravity = 9.81f;

    Vector3 velocity;

    void Update()
    {
        if (transform.position.y == 0)
        {
            bool up = Input.GetKeyDown(upKey);
            bool down = Input.GetKeyDown(downKey);
            bool right = Input.GetKeyDown(rightKey);
            bool left = Input.GetKeyDown(leftKey);

            //if (!up && !down && !right && !left)
            //    return;

            Vector3 dir;
            if (up)
                dir = Vector3.forward;
            else if (down)
                dir = Vector3.back;
            else if (right)
                dir = Vector3.right;
            else if (left)
                dir = Vector3.left;
            else
                dir = Vector3.zero;

            if (dir != Vector3.zero)
            {
                velocity = dir * horizontalSpeed;
                velocity += Vector3.up * verticalSpeed;
            }
        }

        // ------

        transform.position += velocity * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (transform.position.y > 0)
        {
            velocity += Vector3.down * gravity * Time.fixedDeltaTime;
        }
        else 
        {
            velocity = Vector3.zero;

            Vector3 pos = transform.position;
            pos.y = 0;
            transform.position = pos;
        }
    }
}
