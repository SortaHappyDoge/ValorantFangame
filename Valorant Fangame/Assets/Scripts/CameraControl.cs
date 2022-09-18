using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] Transform playerCamera;
    [SerializeField] Transform playerBody;

    public float mouseSens = 10f;
    float mouseX;
    float mouseY;
    float mouseXz;
    float xRotation;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX += Input.GetAxisRaw("Mouse X") * mouseSens;
        mouseY = Input.GetAxisRaw("Mouse Y") * mouseSens;
        mouseXz = Input.GetAxisRaw("Mouse X") * mouseSens;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        playerCamera.rotation = Quaternion.Euler(xRotation, mouseX, 0);

        playerBody.Rotate(0, mouseXz, 0);
    }
    /*void FixedUpdate()
    {
        
    }*/
}
