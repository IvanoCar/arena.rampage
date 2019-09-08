using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    public Transform explosionPrefab;
    UnityEngine.AI.NavMeshAgent nav;
    int hits = 0;

    void Start() {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            nav.enabled = false;
            if (PlayerHealth.isDead) {
                return;
            } else {
                Invoke("EnableNav", 2);
            }
        }
    }

    private void EnableNav() {
        nav.enabled = true;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rocket") {
            IncreaseScore();
            InstantiateExplosion(collision);
        } else if(collision.gameObject.tag == "mgbullet") {
            hits += 1;
            if(hits >= 3) {
                IncreaseScore();
                InstantiateExplosion(collision);
            }
        }
    }

    void InstantiateExplosion(Collider collision) {
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, transform.position);
        Vector3 pos = transform.position;
        Instantiate(explosionPrefab, pos, rot);

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    void IncreaseScore() {
        if(gameObject.tag == "Enemy") {
            ScoreController.score += 100;
        } else { // if tag == EnemyPlane
            ScoreController.score += 300;
        }
    }
}
