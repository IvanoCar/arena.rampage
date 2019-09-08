using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour {

    public Rigidbody bullet;
    public float speed = 400f;
    public float fireRate = 0.45f;

    private Rigidbody instance;
    private Vector3 pos;
    private Vector3 aimingDirection;
    private float timer;


    void Update()
    {
        timer += Time.deltaTime;
        pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40); // opt -> z-os
        pos = Camera.main.ScreenToWorldPoint(pos);
        aimingDirection = pos - transform.position;
        transform.rotation = Quaternion.LookRotation(aimingDirection);

        if (Input.GetMouseButtonDown(0) && timer >= fireRate) {
            timer = 0;
            instance = Rigidbody.Instantiate(bullet, transform.position, transform.rotation);
            instance.velocity = transform.forward * speed;
        }
    }
}
