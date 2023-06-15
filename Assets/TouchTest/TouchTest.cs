using UnityEngine;

public class TouchTest : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    [SerializeField] float multiplier = 1;
    [SerializeField] float timeLimit = 0.2f;

    Vector2 mouseDownPos;
    float mouseDownTime;

    void Update()
    {
        bool mouseDown = Input.GetMouseButtonDown(0);
        if (mouseDown)
        {
            Vector2 mouseDownPixel = Input.mousePosition;
            mouseDownPos = Camera.main.ScreenToViewportPoint(mouseDownPixel);
            mouseDownTime = Time.time;
            return;
        }

        bool mouseIsDown = Input.GetMouseButton(0);
        if (mouseIsDown  && Time.time - mouseDownTime <= timeLimit)
        {
            Vector2 mouseCurrentPixel = Input.mousePosition;
            Vector2 mouseCurrentPos = Camera.main.ScreenToViewportPoint(mouseCurrentPixel);

            Vector2 movement = mouseCurrentPos - mouseDownPos;
            movement.x /= Camera.main.aspect;


            // Forgatás
            rigidBody.velocity = movement * multiplier;
            float angle = -Vector2.SignedAngle(movement, Vector2.up);
            rigidBody.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
