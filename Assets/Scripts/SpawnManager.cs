using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalPrefabs;
    private const float SPAWN_RANGE_X = 13.0f;
    private const float SPAWN_RANGE_Z = 20.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int randomIndex = Random.Range(0, _animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-SPAWN_RANGE_X, SPAWN_RANGE_X), 0, SPAWN_RANGE_Z);

            Instantiate(_animalPrefabs[randomIndex], spawnPos, _animalPrefabs[randomIndex].transform.rotation);
        }
    }
}
