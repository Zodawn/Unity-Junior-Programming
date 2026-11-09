
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerController playerControllerScript;
    private float leftBound = -15f;

    // Start is called before the first frame update
    private void Start()
    {
        // Find the Player object and get its PlayerController script
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            playerControllerScript = player.GetComponent<PlayerController>();
        }
    }

    // Update is called once per frame

        private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

