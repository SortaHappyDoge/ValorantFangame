using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField] Rigidbody playerRB;
    [SerializeField] GroundCheck groundCheck;

    [SerializeField] float groundDrag;
    [SerializeField] float speed = 9;
    [SerializeField] float maxSpeed = 10;
    bool isGrounded;
    float moveForward;
    float moveRight;
    //float totalForce;
    void Start()
    {
        
    }

    void Update()
    {
        moveRight = speed * Input.GetAxisRaw("Horizontal");
        moveForward = speed * Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        isGrounded = groundCheck.isGrounded;
        
        

        if(isGrounded == true)
        {
            playerRB.drag = groundDrag;
            playerRB.AddRelativeForce(moveRight, 0, moveForward);
            if (playerRB.velocity.magnitude > maxSpeed)
            {
                playerRB.velocity = Vector3.ClampMagnitude(playerRB.velocity, maxSpeed);
            }
        }
        else
        {
            playerRB.drag = 0;
        }
    }
}
