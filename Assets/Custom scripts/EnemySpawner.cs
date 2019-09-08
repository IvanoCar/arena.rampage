using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 4f;
    public Transform[] spawnPoints;



    void Start()
    {
       InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        if (PlayerHealth.isDead) {
                return;
        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length < 7) {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }
}