using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dog;

   // private float startDelay=5.0f;
   // private float spawnInterval=0f;


    void Start()
    {
       // InvokeRepeating("SpawnDog",startDelay,spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dog, transform.position, dog.transform.rotation);
        }
    }

    void SpawnDog()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dog, transform.position, dog.transform.rotation);
        }
    }
}
