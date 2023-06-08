using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] CameraController cameraController;

    [SerializeField] float horizontalSensitivity = 1;
    [SerializeField] float verticalSensitivity = 1;
    [SerializeField] bool invertMouseVertical = true;

    [SerializeField] bool disableCursor;

    void Start()
    {
        if(disableCursor)
            Cursor.visible = false;
    }

    void Update()
    {
        float mouseMovementX = Input.GetAxis("Mouse X");
        float mouseMovementY = Input.GetAxis("Mouse Y");

        cameraController.horizontalAngle += mouseMovementX * horizontalSensitivity;

        float verticalM = invertMouseVertical ? 1 : -1;
        cameraController.verticalAngle += mouseMovementY * verticalSensitivity * verticalM;
    }
}