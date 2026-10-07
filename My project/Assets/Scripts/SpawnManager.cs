using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    private float spawnRangeX = 20;
    private float spawnPositionZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnpos = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            0,
            spawnPositionZ
        );

        Instantiate(
            animalPrefabs[animalIndex],
            spawnpos,
            animalPrefabs[animalIndex].transform.rotation
        );
    }
}
