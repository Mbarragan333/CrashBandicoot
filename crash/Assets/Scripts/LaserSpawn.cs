using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//wright shane
//10-20-23

public class LaserSpawn : MonoBehaviour
{
    public GameObject laserPrefab;
    public float spawnRate;
    public bool shootRight;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaser", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnLaser()
    {
        GameObject laserInstance = Instantiate(laserPrefab, transform.position, transform.rotation);
        laserInstance.GetComponent<Laser>().moveRight = shootRight;
    }
}
