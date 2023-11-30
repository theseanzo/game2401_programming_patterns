using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject[] targetPrefabs;

    [SerializeField]
    float spawnTime = 5.0f;
    
    float currentTime = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //let's increment the current time and then every time we go more than the spawn time we instantiate an animal
        currentTime += Time.deltaTime;
        if(currentTime >= spawnTime)
        {
            Instantiate(targetPrefabs[Random.Range(0, targetPrefabs.Length)], transform.position, Quaternion.identity);
            currentTime = 0.0f;
        }
    }
}
