using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;
    public InputAction moveAction;
    public Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(9, 3, 7);
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
        transform.position = plane.transform.position + offset;
    }
}
