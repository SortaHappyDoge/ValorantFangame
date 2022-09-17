using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform playerCamera;
    [SerializeField] Transform playerBody;

    public float mouseSens = 10f;
    float mouseX;
    float mouseY;
    float xRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX += Input.GetAxisRaw("Mouse X") * mouseSens;
        mouseY = Input.GetAxisRaw("Mouse Y") * mouseSens;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        playerCamera.rotation = Quaternion.Euler(xRotation, mouseX, playerCamera.rotation.z);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
