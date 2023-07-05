using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyProjectile;
    public float spawnTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;
    void Start()
    {
        spawnTimer = Random.Range(spawnMax, spawnMin);  
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            Instantiate(enemyProjectile, transform.position, Quaternion.identity);
            spawnTimer=Random.Range(spawnMax, spawnMin);
        }

    }
    
}




