using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject ProjectilePrefab;
    public InputAction fireAction;
    private float topBound = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > topBound) { Destroy(gameObject); }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.right * moveInput.x * speed * Time.deltaTime);
        if (fireAction.triggered)
            {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);


        }
    }
}
