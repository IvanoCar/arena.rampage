using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlayer : MonoBehaviour {

    public Rigidbody bullet;
    Transform player;
    public float speed = 80f;
    public float fireRate = 5f;

    private Rigidbody instance;
    private Vector3 aimingDirection;
    private float timer;

    private void Start()
    {
        if (!PlayerHealth.isDead)
            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if(PlayerHealth.isDead) {
            return;
        }

        timer += Time.deltaTime;
        aimingDirection = player.position - transform.position;
        transform.rotation = Quaternion.LookRotation(aimingDirection);
     

        if (timer >= fireRate)  {
            timer = 0;
            instance = Rigidbody.Instantiate(bullet, transform.position, transform.rotation);
            instance.velocity = transform.forward * speed;
        }
    }
}
