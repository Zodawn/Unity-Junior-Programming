using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward based on the vertical input axis (W/S or Up/Down arrow keys)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
