using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed;
    public float verticalInput;
    public InputAction moveAction;
    public Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
