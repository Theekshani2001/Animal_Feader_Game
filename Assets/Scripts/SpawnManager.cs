using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnX=12.0f;
    private float spawnZ=20.0f;
   
    private float spawnDelay= 2.0f;
    private float spawnInterval=1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",spawnDelay,spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex=Random.Range(0,animalPrefabs.Length);
        Vector3 position=new Vector3(Random.Range(-spawnX,spawnX),0,spawnZ);
        Instantiate(animalPrefabs[animalIndex],position,animalPrefabs[animalIndex].transform.rotation);

    }
}
