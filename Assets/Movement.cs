using UnityEngine;

public class Movement : MonoBehaviour
{

    float movementSpeed = 10f;
    Rigidbody rigidBody;
    int jumpForce = 80;
    float forceOfGravity = 9.8f;
    [SerializeField] Vector3 gravity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        rigidBody.linearDamping = 0f;
        rigidBody.angularDamping = 0.05f;

        // If you want stronger gravity (to fall faster), increase gravity scale
       gravity = Physics.gravity = new Vector3(0, -60f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 vector2 = new Vector3(horizontalMovement, 0, verticalMovement) * movementSpeed;
        rigidBody.AddForce(vector2);

        rigidBody.linearVelocity = vector2;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = new Vector3(0, jumpForce, 0);
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange); 
            rigidBody.linearVelocity = jumpVector;
            
        }

    }

    private void FixedUpdate()
    {

        rigidBody.AddForce(Vector3.up * jumpForce);
    }

}
