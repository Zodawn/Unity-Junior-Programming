using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 50.0f;
    public InputAction moveAction;
    public Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame 
    void Update()
    {
        // We'll move the vehicle forward based on the vertical input axis (W/S or Up/Down arrow keys)

        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * moveInput.x);
        
    }
}
