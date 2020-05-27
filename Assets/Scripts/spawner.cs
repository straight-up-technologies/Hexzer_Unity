using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawner : MonoBehaviour
{
    public float SpawnRate ;
    
    public GameObject hexprefab;
    private float NextSpawnRate = 0f;
    
    
    // Update is called once per frame
    void Update()
    {
        if(SpawnRate <= 0.6f)
        {
            SpawnRate = 2f ;
        }
        if(Time.time >= NextSpawnRate)
        {
            Instantiate(hexprefab, Vector3.zero, Quaternion.identity);
            NextSpawnRate = Time.time + SpawnRate;

            SpawnRate = SpawnRate - 0.01f;
           

        }
    }
}
