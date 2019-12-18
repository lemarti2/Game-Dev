using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontalSpeed = 3.0f;
    float verticalSpeed = 3.0f;
    float pushPower = 2.0f;
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/
    public float walkSpeed = 50.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0F;
    CharacterController myCharacterController = null;

    void Start()
    {
    myCharacterController = GetComponent<CharacterController>();
    }

    void MovePlayer()
    {
    moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    moveDirection = transform.TransformDirection(moveDirection);
    moveDirection *= walkSpeed;

    //moveDirection.y -= gravity * Time.deltaTime;
    myCharacterController.Move(moveDirection * Time.deltaTime);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body !=null && !body.isKinematic)
            body.velocity = hit.controller.velocity * pushPower;
    }

    // Update is called once per frame
    void Update()
    { 
       // Get Horizontal and Vertical Input
    float horizontalInput = Input.GetAxis ("Horizontal");
    float verticalInput = Input.GetAxis ("Vertical");

   // Calculate the Direction to Move based on the tranform of the Player
    Vector3 moveDirectionForward = transform.forward * verticalInput;
    Vector3 moveDirectionSide = transform.right * horizontalInput;

    //find the direction
    Vector3 direction = (moveDirectionForward + moveDirectionSide).normalized;
    //find the distance
    Vector3 distance = direction * walkSpeed * Time.deltaTime;

    // Apply Movement to Player
    myCharacterController.Move (distance);
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
        //transform.Translate(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    }
}
