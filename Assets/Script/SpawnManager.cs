using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalPosX = Random.Range(-10, 10);
        Instantiate(animalPrefabs[animalIndex], new Vector3(animalPosX, 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}
