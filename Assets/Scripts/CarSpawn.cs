using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] carsToSpawn;
    private float timeToSpawn;
    private Transform positionOfSpawnPoint;
    private Coroutine coroutineToSpawnCar;

    private void Start()
    {
        coroutineToSpawnCar = StartCoroutine(SpawnCar());
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            timeToSpawn = Random.Range(1f,10f);
            GameObject spawnedCar = Instantiate(carsToSpawn[Random.Range(0, carsToSpawn.Length)], transform.position,transform.rotation);
            yield return new WaitForSeconds(timeToSpawn);
        }
    }
}