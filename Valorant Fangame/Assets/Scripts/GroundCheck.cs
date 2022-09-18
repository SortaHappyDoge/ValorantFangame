using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] float maxDistance = 0.55f;
    [SerializeField] Transform playerMiddle;
    public bool isGrounded;

    

    void Start()
    {
        
    }

    

    void Update()
    {
        Ray ray = new(playerMiddle.position, -Vector3.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
                if (hit.collider.tag != "Environment")
                {
                    isGrounded = false;
                }
                else /*if (hit.collider.tag == "Environment")*/
                {
                    isGrounded = true;
                }                      
        }
        else
        {
            isGrounded = false;
        }
        //Debug.Log(isGrounded);
    }
}
