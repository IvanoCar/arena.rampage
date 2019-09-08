using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public Transform explosionPrefab;
    public Slider healthSlider;
    GameOver gameOver;
    [HideInInspector] public int currentHealth;
    [HideInInspector] public static bool isDead;

    private void Start()
    {
        currentHealth = startingHealth;
        gameOver = GameObject.Find("GameController").GetComponent<GameOver>();
        isDead = false;

    }

    public void TakeDamage(int amount) {
        currentHealth -= amount;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0) {
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, transform.position);
            Vector3 pos = transform.position;
            Instantiate(explosionPrefab, pos, rot);

            gameOver.GameOverCall();
            isDead = true;
            Destroy(gameObject, 0);            
        }
    }
}

