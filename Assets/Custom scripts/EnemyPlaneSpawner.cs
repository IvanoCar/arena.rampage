using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlaneSpawner : MonoBehaviour {

    public GameObject enemy;
    public float spawnTime = 15f;
    public Transform spawnPoint;



    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        if (PlayerHealth.isDead) {
            return;
        }
        if (GameObject.FindGameObjectsWithTag("EnemyPlane").Length < 1) {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
