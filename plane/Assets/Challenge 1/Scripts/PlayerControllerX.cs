using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
    }

    public InputAction moveAction;

    private Vector2 moveInput;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward/back based on vertical input
        transform.Rotate(Vector3.left * Time.deltaTime * verticalInput * rotationSpeed);

        // tilt the plane up/down based on vertical input
        transform.Translate(Vector3.up * Time.deltaTime * verticalInput * speed);
    }
}
