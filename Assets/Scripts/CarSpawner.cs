using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay = 1f;
    [SerializeField] private float nextTimeToSpawn = .5f;

    [SerializeField] private GameObject car;

    [SerializeField] private Transform[] spawnPoints;

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }
    private void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length - 1);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
