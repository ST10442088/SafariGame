using Unity.VisualScripting;
using UnityEngine;

public class FalseMovement : MonoBehaviour
{
    Vector3 movementVector = Vector3.zero;
    float movementSpeed = 40f;
    CharacterController characterController;

    float jumpSpeed = 8f;
    float verticalSpeed;
    float constantDownwardForce = -2f;
    float gravity = -9.8f;
    float smallestAmount_OfVelocity = -10f;

    bool isOnGround = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        verticalSpeed = constantDownwardForce;
      ;
    }

    // Update is called once per frame
    void Update()
    {


        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.z = Input.GetAxis("Vertical");


            if (characterController.isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    verticalSpeed = jumpSpeed;
                }
                else
                {
                    verticalSpeed = constantDownwardForce;
                }
            }
            else
            {
                verticalSpeed += gravity * 3 * Time.deltaTime;
                if (verticalSpeed < smallestAmount_OfVelocity)
                {
                    verticalSpeed = smallestAmount_OfVelocity;
                }
            }
        movementVector.y = verticalSpeed;
        movementVector *= Time.deltaTime * 25;
        characterController.Move(movementVector);

    }
}
