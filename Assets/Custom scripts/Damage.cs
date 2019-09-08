using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damage : MonoBehaviour {


    PlayerHealth playerHealth;
    float time;

    public int hitDamageAmount = 10;
    public double timeBetweenAttacks = 0.7;


    void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        time = Time.time;
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if(collision.gameObject.tag == "Enemy" && Time.time >= time + timeBetweenAttacks) {
            time = Time.time;
            playerHealth.TakeDamage(hitDamageAmount);
        }

        if(collision.gameObject.tag == "bomb") {
            playerHealth.TakeDamage(hitDamageAmount*2);
        }
    }
}
