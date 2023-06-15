using UnityEngine;

class KeyboardController : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] Transform cameraTransform;

    [SerializeField] Damageable damageable;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] Animator animator;

    void OnValidate()
    {
        if(damageable == null)
            damageable = GetComponent<Damageable>();
        if (animator == null)
            animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (damageable != null && !damageable.IsAlive)
            return;

        Vector3 direction = GetInputDirection();

        bool isMoving = direction != Vector3.zero;
        animator.SetBool("IsWalking", isMoving);

        if (isMoving)
        {
            Vector3 velocity = direction * speed;
            rigidBody.MovePosition(rigidBody.position + velocity * Time.deltaTime);

            Quaternion targetRot = Quaternion.LookRotation(direction);
            Quaternion currentRot = transform.rotation;

            float step = angularSpeed * Time.deltaTime;
            rigidBody.rotation = Quaternion.RotateTowards(currentRot, targetRot, step);

            // transform.rotation = Quaternion.LookRotation(direction);

        }
    }

    Vector3 GetInputDirection() 
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool upButton = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool downButton = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

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

        // ---------------

        // Vector3 d = new Vector3(x, 0, z);   // GLOBÁLIS TÉRBEN

        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraForward = cameraTransform.forward;

        Vector3 d = x * cameraRight + z * cameraForward;
        d.y = 0;

        d.Normalize();
        return d;
    }
}