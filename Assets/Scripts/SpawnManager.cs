using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;
    private const float SPAWN_RANGE_X = 13.0f;
    private const float SPAWN_RANGE_Z = 20.0f;
    private const float START_DELAY = 2.0f;
    private const float SPAWN_INTERVAL = 1.5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), START_DELAY, SPAWN_INTERVAL);
    }

    private void SpawnRandomAnimal()
    {
        int randomIndex = Random.Range(0, _animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-SPAWN_RANGE_X, SPAWN_RANGE_X), 0, SPAWN_RANGE_Z);

        Instantiate(_animalPrefabs[randomIndex], spawnPos, _animalPrefabs[randomIndex].transform.rotation);
    }
}
