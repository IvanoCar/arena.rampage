using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;

    void Start()
    {
        if(!PlayerHealth.isDead)
            player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (nav.enabled && !PlayerHealth.isDead) {
            nav.SetDestination(player.position);
        } else {
            nav.enabled = false;
        }
    }
}