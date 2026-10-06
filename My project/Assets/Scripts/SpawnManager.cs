using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnpositionZ = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnAction.triggered)
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnpositionZ);

            Instantiate(animalPrefabs[animalIndex], spawnPosition, transform.rotation);

        }
    }
}
